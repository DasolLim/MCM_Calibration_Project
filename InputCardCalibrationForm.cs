using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using ModbusCommanderScriptingPlugin;
using ModbusCommander;
using System.IO;
using System.Threading;
using System.Xml;

using NLua;
using NLua.Exceptions;

namespace ModbusCommanderProductionPlugin
{
   public partial class InputCardCalibrationForm : Form
   {

      private MoreVariablesForm moreVariables = new MoreVariablesForm();

      //connects lua scripting
      private InputCardCalibrationScriptApi luaApi;
      //used for running lua script in a seperate thread within the form
      private Thread luaThread = null;

      //store computer graphic
      private static Bitmap goBitmap;
      private static Bitmap stopBitmap;

      private String loadedFilename = "";
      
      //connect lua script with InputCardCalibrationForm.cs
      public InputCardCalibrationScriptApi ScriptApi
      {
         get { return luaApi; }
      }
      
      public ConsoleOutput ScriptOutput
      {
         get;
         private set;
      }

      /* 
      public ToolStripStatusLabel ExclaimationLabel
      {
         get { return exclaimationLabel; }
      }
      */

      public ToolStripStatusLabel StatusLabel
      {
         get { return statusLabel; }
      }

      //connect lua script with MC
      public ModbusCommanderApi Api
      {
         get { return luaApi.Api; }
         set { luaApi.Api = value; }
      }

      //More Variables
      public String UserValue(String name)
      {
         return moreVariables.ValueOf(name);
      }

      public String UserDescription(String name)
      {
         return moreVariables.DescriptionOf(name);
      }
      public List<String> UserVariables
      {
         get { return moreVariables.Variables; }
      }

      public InputCardCalibrationForm(ModbusCommanderApi api)
      {
         InitializeComponent();

         //bitmap: works with image defined pixel data
         goBitmap = ModbusCommanderScriptingPlugin.Properties.Resources.go;
         stopBitmap = ModbusCommanderScriptingPlugin.Properties.Resources.stop;

         pulseModeComboBox.SelectedIndex = 0;
         voltageModeComboBox.SelectedIndex = 0;
         currentModeComboBox.SelectedIndex = 0;

         //goPauseButton =  run calibration button
         goPauseButton.Image = goBitmap;

         luaApi = new InputCardCalibrationScriptApi(this, api);
         //if any change while running the script, pause the execution of the code
         luaApi.ExecutingChanged += (s, executing) => SetGoPauseButtonState(!executing);

         //setting console output
         ScriptOutput = new ConsoleOutput();
         ScriptOutput.Location = scriptOutput.Location;
         ScriptOutput.Size = scriptOutput.Size;
         ScriptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         this.Controls.Add(ScriptOutput);

         // Reacts whenever an integer value has been changed
         cycleNum.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
         offsetNum.ValueChanged += new EventHandler(numericUpDown2_ValueChanged);
         validRange.ValueChanged += new EventHandler(validRange_ValueChanged);
      }

      //running lua script
      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.F5)
            goPauseButton.PerformClick();

         return false;
      }

      //cycleNum
      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {

      }
      
      public uint AveragingCycle
      {
         get { return (uint)cycleNum.Value; }
         set { cycleNum.Value = (int)value; }
      }

      private void validRange_ValueChanged(object sender, EventArgs e)
      {

      }

      private void SetGoPauseButtonState(bool go)
      {
         //if special invoke is required to use the control and new thread creates the control
         if (InvokeRequired)
         {
            //new object[] {}, creating and initializing an array of object that is going to be passed as a parameter
            this.Invoke(new Action<bool>(SetGoPauseButtonState), new object[] { go });
            return;
         }

         if (go)
            goPauseButton.Image = goBitmap;
         else
            goPauseButton.Image = stopBitmap;
      }

      public void Run (String filename)
      {
         this.ScriptOutput.Select();

         FileInfo info = new FileInfo(filename);

         luaApi.Script = filename;
         luaApi.ScriptName = info.Name;
         this.Text = luaApi.ScriptName;

         luaApi.ResetLua();
         Directory.SetCurrentDirectory(info.Directory.FullName);
         luaThread = new Thread(new ThreadStart(() => luaApi.Execute(filename)));
         luaThread.Start();
      }

      //Run Calibration Button
      private void goPauseButton_Click(object sender, EventArgs e)
      {
         if (goPauseButton.Image == goBitmap)
            Run(scriptPath.Text);
         else
            luaApi.Terminate();
      }

      public class InputCardCalibrationScriptApi : ScriptApi
      {
         private InputCardCalibrationForm form;
         private ModbusCommanderApi api;

         public InputCardCalibrationScriptApi(InputCardCalibrationForm form, ModbusCommanderApi api) : base(api)
         {
            this.form = form;
            this.api = api;

            this.ResetLua();
         }

          public override void ResetLua()
          {
            base.ResetLua();
          
            this.RegisterMember(typeof(InputCardCalibrationScriptApi), "GetUnsignedIntegerParameter");
            this.RegisterMember(typeof(InputCardCalibrationScriptApi), "GetFloatingPointParameter");
            this.RegisterMember(typeof(InputCardCalibrationScriptApi), "GetStringParameter");
            this.RegisterMember(typeof(InputCardCalibrationScriptApi), "GetBooleanParameter");
            this.RegisterMember(typeof(InputCardCalibrationScriptApi), "termClear");
          }

         public ModbusCommanderApi Api
         {
            get { return api; }
            set { api = value; }
         }

         public uint GetUnsignedIntegerParameter(String name)
         {
            //InvokeRequired: compare the control's creating thread ID to calling thread ID
            //If they are different, changes have been made, then calls the Invoke method
            
            if (this.form.InvokeRequired)
            {
               return (uint)this.form.Invoke(new Func<uint>(() => GetUnsignedIntegerParameter(name)));
            }

            name = name.ToUpper();
            if (name == "CYCLENUM")
               return form.AveragingCycle;
            else if (name == "OFFSETNUM")
               return form.AveragingOffset;
            else if (name == "INITIALMODE")
               return form.InitialMode;
            else if (name == "FINALMODE")
               return form.FinalMode;
            else if (name == "PULSEMODE")
               return form.PulseMode;
            else if (name == "VOLTAGEMODE")
               return form.VoltageMode;
            else if (name == "CURRENTMODE")
               return form.CurrentMode;
            else
               return 0;
         }

         public double GetFloatingPointParameter(String name)
         {
            if (this.form.InvokeRequired)
            {
               return (double) this.form.Invoke(new Func<double>(() => GetFloatingPointParameter(name)));
            }

            name = name.ToUpper();

            if (name == "VALIDRANGE")
               return form.ValidRange;
            else if (name == "FIRMWAREVERSION")
               return form.FirmwareVersion;
            else if (name == "BOOTLOADERVERSION")
               return form.BootloaderVersion;
            else if (name == "PULSEMODERATIO")
               return form.PulseModeRatio;
            else if (name == "VOLTAGEMODERATIO")
               return form.VoltageModeRatio;
            else if (name == "CURRENTMODERATIO")
               return form.CurrentModeRatio;
            else
               return 0;
         }

         public bool GetBooleanParameter(String name)
         {
            if (this.form.InvokeRequired)
            {
               return (bool)this.form.Invoke(new Func<bool>(() => GetBooleanParameter(name)));
            }

            name.ToUpper();

            if (name == "CONTINUOUSMODE")
               return form.ContinuousMode;
            else if (name == "OFFSETCALIBRATIONCHECKBOX")
               return form.OffsetCalibration;
            else if (name == "RECALIBRATECHECKBOX")
               return form.ForceRecalibrate;
            else
               return false;
         }

         public String GetStringParameter(String name)
         {
            if (this.form.InvokeRequired)
            {
               return (String)this.form.Invoke(new Func<String>(() => GetStringParameter(name)));
            }

            name = name.ToUpper();

            if (name == "POSTCALIBRATIONSCRIPT")
            {
               return form.PostCalibrationScript;
            }
            else
            {
               List<String> userVariables = form.UserVariables;
               for (int i = 0; i < userVariables.Count; ++i)
               {
                  if (userVariables[i].ToUpper() == name)
                     return form.UserValue(name);
               }
            }

            return "";
         }

         //abstract class, ScriptApi, functions
         public override void termClear()
         {
            form.ScriptOutput.Clear();
         }

         public override void termClearLine()
         {
            form.ScriptOutput.ClearLine();
         }

         public override void termGetCursorPos(out int x, out int y)
         {
            x = form.ScriptOutput.X;
            y = form.ScriptOutput.Y;
         }

         public override void termSetCursorPos(int x, int y)
         {
            form.ScriptOutput.X = x;
            form.ScriptOutput.Y = y;
         }

         public override void print(string text)
         {
            // "\r" moves the cursor to the beginning of the current line
            write(text + "\r\n");
         }

         public override void write(string text)
         {
            form.ScriptOutput.Write(text);
         }

         public override void setStatus(String text, bool exclaimation = false)
         {
            if (form.InvokeRequired)
            {
               form.Invoke(new Action<string, bool>(setStatus), new object[] { text, exclaimation });
               return;
            }

            //form.ExclaimationLabel.Visible = exclaimation;
            form.StatusLabel.Text = text;
         }

         public override void termSetColor(double r, double g, double b)
         {
            Color color = Color.FromArgb((int)Math.Round(r * 0xFF, 0), (int)Math.Round(g * 0xFF, 0), (int)Math.Round(b * 0xFF, 0));
            form.ScriptOutput.SetColor(color);
         }

         public override void termSetBold(bool value)
         {
            form.ScriptOutput.SetBold(value);
         }

         public override void termSetItalic(bool value)
         {
            form.ScriptOutput.SetItalic(value);
         }

         public override void termSetUnderline(bool value)
         {
            form.ScriptOutput.SetUnderline(value);
         }

         public override void termSetStrikethrough(bool value)
         {
            form.ScriptOutput.SetStrikethrough(value);
         }

         public override void termClearFormatting()
         {
            form.ScriptOutput.ClearFormatting();
         }
      }

      // Continuous Mode Check Box
      public bool ContinuousMode
      {
         get { return continuousModeCheckBox.Checked; }
         set { continuousModeCheckBox.Checked = value; }
      }

      // Force Recalibrate Check Box
      public bool ForceRecalibrate
         {
         get { return recalibrateCheckBox.Checked; }
         set { recalibrateCheckBox.Checked = value; }
         }

      // Calibration Setting

      // Calibration Inputs
      public uint PulseMode
      {
         get { return (uint)pulseModeComboBox.SelectedIndex; }
         set { pulseModeComboBox.SelectedIndex = (int)value; }
      }

      public uint VoltageMode
      {
         get { return (uint)voltageModeComboBox.SelectedIndex; }
         set { voltageModeComboBox.SelectedIndex = (int)value; }
      }
      public uint CurrentMode
      {
         get { return (uint)currentModeComboBox.SelectedIndex; }
         set { currentModeComboBox.SelectedIndex = (int)value; }
      }

      // Pulse Ratio Text Box Method
      public double PulseModeRatio
      {
         get
         {
            try
            {
               return double.Parse(pulseRatio.Text);
            }
            catch(Exception e)
            {
               return 0.0;
            }
         }
         set
         {
            pulseRatio.Text = value.ToString();
         }
      }

      // Voltage Ratio Text Box Method
      public double VoltageModeRatio
      {
         get
         {
            try
            {
               return double.Parse(voltageRatio.Text);
            }
            catch (Exception e)
            {
               return 0.0;
            }
         }
         set
         {
            voltageRatio.Text = value.ToString();
         }
      }


      // Current Ratio Text Box Method
      public double CurrentModeRatio
      {
         get
         {
            try
            {
               return double.Parse(currentRatio.Text);
            }
            catch (Exception e)
            {
               return 0.0;
            }
         }
         set
         {
            currentRatio.Text = value.ToString();
         }
      }



      public String PostCalibrationScript
      {
         get { return postScript.Text; }
         set { postScript.Text = value; }
      }

      private void SaveConfiguration(String filename)
      {
         //creating a dictionary for register members
         Dictionary<String, String> values = new Dictionary<string, string>();

         //adding values into the dictionary
         values.Add("AveragingCycle", AveragingCycle.ToString());
         values.Add("AveragingOffset", AveragingOffset.ToString());
         values.Add("InitialMode", InitialMode.ToString());
         values.Add("FinalMode", FinalMode.ToString());
         values.Add("ValidRange", ValidRange.ToString());
         values.Add("FirmwareVersion", FirmwareVersion.ToString());
         values.Add("BootloaderVersion", BootloaderVersion.ToString());
         values.Add("ContinuousMode", ContinuousMode.ToString());
         values.Add("OffsetCalibration", OffsetCalibration.ToString());
         values.Add("ForceRecalibrate", ForceRecalibrate.ToString());
         values.Add("PostCalibrationScript", PostCalibrationScript);
         values.Add("PulseMode", PulseMode.ToString());
         values.Add("VoltageMode", VoltageMode.ToString());
         values.Add("CurrentMode", CurrentMode.ToString());
         values.Add("PulseModeRatio", PulseModeRatio.ToString());
         values.Add("VoltageModeRatio", VoltageModeRatio.ToString());
         values.Add("CurrentModeRatio", CurrentModeRatio.ToString());

         values.Add("ScriptPath", scriptPath.Text);


         //populating each values in corresponding format
         foreach (String variable in UserVariables)
         {
            values.Add("User." + variable + ":" + UserDescription(variable), UserValue(variable));
         }

         // writes XML, which stores and transports data, to a stream or file
         using (XmlWriter writer = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
         {
            //used to serialize and deserialize data sent in Windows Communication Foundation messages
            //serialize: used for converting the state of an object and transporting
            DataContractSerializer serializer = new DataContractSerializer(
                typeof(Dictionary<String, String>),
                null,
                Int32.MaxValue, false, false, null,
                new AllowAllContractResolver()
             );

            serializer.WriteObject(writer, values);
         }
      }

      // Calibration Script Path Browse
      private void button1_Click(object sender, EventArgs e)
      {
         OpenFileDialog dialog = new OpenFileDialog();
         dialog.Filter = "Script Files (*.lua)|*.lua|All Files (*.*)|*.*";
         dialog.InitialDirectory = SettingsFile.Instance.GetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationScriptDirectory", dialog.InitialDirectory);

         DialogResult result = dialog.ShowDialog();

         if (result != System.Windows.Forms.DialogResult.OK)
            return;

         SettingsFile.Instance.SetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationScriptDirectory", Path.GetDirectoryName(dialog.FileName));
         SettingsFile.Save(SettingsFile.Instance);

         scriptPath.Text = dialog.FileName;
      }

      private void saveConfigurationAsButton_Click(object sender, EventArgs e)
      {
         SaveFileDialog dialog = new SaveFileDialog();
         dialog.AddExtension = true;
         dialog.Filter = "Calibration Files (*.mccs; **.xml)|*.mccs; *.xml|All Files (*.*)|*.*";
         dialog.InitialDirectory = SettingsFile.Instance.GetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationDirectory", dialog.InitialDirectory);

         DialogResult result = dialog.ShowDialog();

         if (result != System.Windows.Forms.DialogResult.OK)
            return;

         SettingsFile.Instance.SetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationDirectory", Path.GetDirectoryName(dialog.FileName));
         SettingsFile.Save(SettingsFile.Instance);

         SaveConfiguration(dialog.FileName);
      }

      private void postScriptBtn_Click(object sender, EventArgs e)
      {
         OpenFileDialog dialog = new OpenFileDialog();
         dialog.Filter = "Script Files (*.lua)|*.lua|All Files (*.*)|*.*";
         dialog.InitialDirectory = SettingsFile.Instance.GetAdditionalSetting<String>("ProductionPlugin_LastUsedPostCalibrationScriptDirectory", dialog.InitialDirectory);

         DialogResult result = dialog.ShowDialog();

         if (result != System.Windows.Forms.DialogResult.OK)
            return;

         SettingsFile.Instance.SetAdditionalSetting<String>("ProductionPlugin_LastUsedPostCalibrationScriptDirectory", Path.GetDirectoryName(dialog.FileName));
         SettingsFile.Save(SettingsFile.Instance);

         postScript.Text = dialog.FileName;
      }

      private void saveConfigurationButton_Click(object sender, EventArgs e)
      {
         if (loadedFilename == "")
            saveConfigurationAsButton_Click(sender, e);
         else
            SaveConfiguration(loadedFilename);
      }

      private void openConfigurationButton_Click(object sender, EventArgs e)
      {
         OpenFileDialog dialog = new OpenFileDialog();
         dialog.Filter = "Calibration Files (*.mccs; *.xml)|*.mccs; *.xml|All Files (*.*)|*.*";
         dialog.InitialDirectory = SettingsFile.Instance.GetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationDirectory", dialog.InitialDirectory);

         DialogResult result = dialog.ShowDialog();

         if (result != System.Windows.Forms.DialogResult.OK)
            return;

         SettingsFile.Instance.SetAdditionalSetting<String>("ProductionPlugin_LastUsedCalibrationDirectory", Path.GetDirectoryName(dialog.FileName));
         SettingsFile.Save(SettingsFile.Instance);

         String filename = dialog.FileName;

         DataContractSerializer serializer = new DataContractSerializer(
             typeof(Dictionary<String, String>),
             null,
             Int32.MaxValue, false, false, null,
             new AllowAllContractResolver()
          );

         Dictionary<String, String> values;
         try
         {
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
               values = (Dictionary<String, String>)serializer.ReadObject(stream);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error loading file " + filename + ": \r\nThe format was invalid. This file is either not a calibration settings file, or it is corrupt.\r\n\r\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         try
         {
            AveragingCycle = uint.Parse(values["AveragingCycle"]);
            AveragingOffset = uint.Parse(values["AveragingOffset"]);
            InitialMode = uint.Parse(values["InitialMode"]);
            FinalMode = uint.Parse(values["FinalMode"]);

            PulseMode = uint.Parse(values["PulseMode"]);
            VoltageMode = uint.Parse(values["VoltageMode"]);
            CurrentMode = uint.Parse(values["CurrentMode"]);

            ValidRange = uint.Parse(values["ValidRange"]);

            if (values.ContainsKey("PostCalibrationScript"))
            {
               PostCalibrationScript = values["PostCalibrationScript"];
            }

            if (values.ContainsKey("ContinuousMode"))
            {
               ContinuousMode = bool.Parse(values["ContinuousMode"]);
            }

            if (values.ContainsKey("ForceRecalibrate"))
            {
               ForceRecalibrate = bool.Parse(values["ForceRecalibrate"]);
            }

            if (values.ContainsKey("OffsetCalibration"))
            {
               OffsetCalibration = bool.Parse(values["OffsetCalibration"]);
            }

            PulseModeRatio = double.Parse(values["PulseModeRatio"]);
            VoltageModeRatio = double.Parse(values["VoltageModeRatio"]);
            CurrentModeRatio = double.Parse(values["CurrentModeRatio"]);

            FirmwareVersion = double.Parse(values["FirmwareVersion"]);
            BootloaderVersion = double.Parse(values["BootloaderVersion"]);

            moreVariables = new MoreVariablesForm();

            bool userVariableFound = false;
            foreach (String variable in values.Keys)
            {
               if (variable.StartsWith("User."))
               {
                  userVariableFound = true;
                  String text = variable.Replace("User.", "");
                  String[] parts = text.Split(':');
                  if (parts.Length == 2)
                     moreVariables.SetValueOf(parts[0], values[variable], parts[1]);
                  else
                     moreVariables.SetValueOf(parts[0], values[variable]);
               }
            }

            if (userVariableFound)
               moreVariableBtn.Font = new Font(moreVariableBtn.Font, FontStyle.Bold | FontStyle.Italic);
            else
               moreVariableBtn.Font = new Font(moreVariableBtn.Font, FontStyle.Regular);


            scriptPath.Text = values["ScriptPath"];

            loadedFilename = filename;
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error loading file " + filename + ": The format was invalid. This file is either not a calibration settings file, or it is corrupt.\r\n\r\nDetails:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      public class AllowAllContractResolver : DataContractResolver
      {
         public override bool TryResolveType(Type dataContractType, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace)
         {
            if (!knownTypeResolver.TryResolveType(dataContractType, declaredType, null, out typeName, out typeNamespace))
            {
               var dictionary = new XmlDictionary();
               typeName = dictionary.Add(dataContractType.FullName);
               typeNamespace = dictionary.Add(dataContractType.Assembly.FullName);
            }
            return true;
         }

         public override Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver)
         {
            return knownTypeResolver.ResolveName(typeName, typeNamespace, declaredType, null) ?? Type.GetType(typeName + ", " + typeNamespace);
         }
      }

      //More Variable Button
      private void button3_Click(object sender, EventArgs e)
      {
         moreVariables.ShowDialog();

         bool found = false;
         foreach (String variable in moreVariables.Variables)
         {
            if (variable.Trim() != "" && variable.Trim() != String.Empty)
               found = true;
         }

         if (found)
            moreVariableBtn.Font = new Font(moreVariableBtn.Font, FontStyle.Bold | FontStyle.Italic);
         else
            moreVariableBtn.Font = new Font(moreVariableBtn.Font, FontStyle.Regular);
      }

      //Final Mode
      private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
      {

      }

      public uint FinalMode
      {
         get { return (uint)numericUpDown1.Value; }
         set { numericUpDown1.Value = (int)value; }
      }

      //Initial Mode
      private void numericUpDown2_ValueChanged(object sender, EventArgs e)
      {

      }

      public uint InitialMode
      {
         get { return (uint)numericUpDown2.Value; }
         set { numericUpDown2.Value = (int)value; }
      }

      //offsetNum
      private void offsetNum_ValueChanged(object sender, EventArgs e)
      {

      }

      public uint AveragingOffset
      {
         get { return (uint)offsetNum.Value; }
         set { offsetNum.Value = (int)value; }
      }

      //validRange (tolerance)
      private void numericUpDown3_ValueChanged(object sender, EventArgs e)
      {

      }

      public uint ValidRange
      {
         get { return (uint)validRange.Value; }
         set { validRange.Value = (int) value; }
      }

      public double FirmwareVersion
      {
         get {
            try
            {
               return double.Parse(firmwareVersion.Text);
            }
            catch
            {
               return 0.0;
            }
         }
         set { firmwareVersion.Text = value.ToString(); }
      }

      public double BootloaderVersion
      {
         get
         {
            try
            {
               return double.Parse(bootloaderVersion.Text);
            }
            catch
            {
               return 0.0;
            }
         }
         set { bootloaderVersion.Text = value.ToString(); }
      }

      //offsetCalibration
      private void offsetCalibrationCheckBox_CheckedChanged(object sender, EventArgs e)
      {

      }

      public bool OffsetCalibration
      {
         get { return offsetCalibrationCheckBox.Checked; }
         set { offsetCalibrationCheckBox.Checked = value; }
      }

      private void UpdateLabel(ComboBox comboBox, int num)
      {
         Label[] label = { pulseValue, voltageValue, currentValue };
         double[] modeRatio = { PulseModeRatio, VoltageModeRatio, CurrentModeRatio };
         string[] labelUnit = { " V", " V", " mA" };
         double modeValue = 0.0;

         if (num == 0 || num == 1)
         {
            if (comboBox.SelectedIndex == 0)
            {
               modeValue = 10;
            }
            else if (comboBox.SelectedIndex == 1)
            {
               modeValue = 12;
            }
         }
         else if (num == 2)
         {
            if (comboBox.SelectedIndex == 0)
            {
               modeValue = 20;
            }
            else if (comboBox.SelectedIndex == 1)
            {
               modeValue = 24;
            }
         }
         else
         {
            Console.Write("ERROR WITH UPDATELABEL");
         }

         double modeCalcuation = modeRatio[num] / 100.0 * modeValue;

         label[num].Text = modeCalcuation.ToString() + labelUnit[num];
      }

      // if combox changes, function is triggered
      private void pulseMode_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateLabel(pulseModeComboBox, 0);
      }

      private void voltageMode_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateLabel(voltageModeComboBox, 1);
      }

      private void currentMode_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateLabel(currentModeComboBox, 2);
      }

      // Text Changed for Mode Ratio
      private void pulseRatio_TextChanged(object sender, EventArgs e)
      {
         UpdateLabel(pulseModeComboBox, 0);
      }

      private void voltageRatio_TextChanged(object sender, EventArgs e)
      {
         UpdateLabel(voltageModeComboBox, 1);
      }

      private void currentPercent_TextChanged(object sender, EventArgs e)
      {
         UpdateLabel(currentModeComboBox, 2);
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void groupBox3_Enter(object sender, EventArgs e)
      {

      }

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }

      private void label4_Click(object sender, EventArgs e)
      {

      }

      private void pulseValue_Click(object sender, EventArgs e)
      {

      }

      private void voltageValue_Click(object sender, EventArgs e)
      {

      }

      private void currentValue_Click(object sender, EventArgs e)
      {

      }

      private void averageCycle_TextChanged(object sender, EventArgs e)
      {

      }

      private void validRange_TextChanged(object sender, EventArgs e)
      {

      }

      private void recalibrateCheckBox_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void firmwareVersion_TextChanged(object sender, EventArgs e)
      {

      }

      private void bootloaderVerison_TextChanged(object sender, EventArgs e)
      {

      }

      private void CalibrationInputs_Enter(object sender, EventArgs e)
      {

      }

      private void CalibrationSettings_Enter(object sender, EventArgs e)
      {

      }

      private void scriptPath_TextChanged(object sender, EventArgs e)
      {
      }

      private void postScript_TextChanged(object sender, EventArgs e)
      {

      }

      private void postScriptLabel_Click(object sender, EventArgs e)
      {

      }

      private void rangeLabel_Click(object sender, EventArgs e)
      {

      }

      private void voltageModeLabel_Click(object sender, EventArgs e)
      {

      }

      private void currentModeLabel_Click(object sender, EventArgs e)
      {

      }

      private void textBox1_TextChanged_1(object sender, EventArgs e)
      {

      }

      private void scriptOutput_TextChanged(object sender, EventArgs e)
      {

      }

      private void label2_Click_1(object sender, EventArgs e)
      {

      }

      private void label2_Click_2(object sender, EventArgs e)
      {

      }

      private void label5_Click(object sender, EventArgs e)
      {

      }

      private void bootloaderVersion_TextChanged(object sender, EventArgs e)
      {

      }
   }
}

