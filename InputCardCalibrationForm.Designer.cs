namespace ModbusCommanderProductionPlugin
{
    partial class InputCardCalibrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputCardCalibrationForm));
         this.ExpectedVersions = new System.Windows.Forms.GroupBox();
         this.bootloaderVersion = new System.Windows.Forms.TextBox();
         this.firmwareVersion = new System.Windows.Forms.TextBox();
         this.bootloaderLabel = new System.Windows.Forms.Label();
         this.firmwareLabel = new System.Windows.Forms.Label();
         this.CalibrationInputs = new System.Windows.Forms.GroupBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.finalMode = new System.Windows.Forms.Label();
         this.initialMode = new System.Windows.Forms.Label();
         this.currentValue = new System.Windows.Forms.Label();
         this.currentModeLabel = new System.Windows.Forms.Label();
         this.voltageValue = new System.Windows.Forms.Label();
         this.currentRatio = new System.Windows.Forms.TextBox();
         this.pulseValue = new System.Windows.Forms.Label();
         this.voltageModeLabel = new System.Windows.Forms.Label();
         this.voltageRatio = new System.Windows.Forms.TextBox();
         this.currentModeComboBox = new System.Windows.Forms.ComboBox();
         this.voltageModeComboBox = new System.Windows.Forms.ComboBox();
         this.pulseRatio = new System.Windows.Forms.TextBox();
         this.pulseModeLabel = new System.Windows.Forms.Label();
         this.pulseModeComboBox = new System.Windows.Forms.ComboBox();
         this.CalibrationSettings = new System.Windows.Forms.GroupBox();
         this.label6 = new System.Windows.Forms.Label();
         this.validRange = new System.Windows.Forms.NumericUpDown();
         this.offsetNum = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.cycleNum = new System.Windows.Forms.NumericUpDown();
         this.recalibrateCheckBox = new System.Windows.Forms.CheckBox();
         this.rangeLabel = new System.Windows.Forms.Label();
         this.cycleLabel = new System.Windows.Forms.Label();
         this.scriptPath = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.scriptPathLabel = new System.Windows.Forms.Label();
         this.postScriptLabel = new System.Windows.Forms.Label();
         this.scipthPathBtn = new System.Windows.Forms.Button();
         this.postScript = new System.Windows.Forms.TextBox();
         this.postScriptBtn = new System.Windows.Forms.Button();
         this.continuousModeCheckBox = new System.Windows.Forms.CheckBox();
         this.moreVariableBtn = new System.Windows.Forms.Button();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.openConfigurationButton = new System.Windows.Forms.ToolStripButton();
         this.saveConfigurationButton = new System.Windows.Forms.ToolStripButton();
         this.saveConfigurationAsButton = new System.Windows.Forms.ToolStripButton();
         this.goPauseButton = new System.Windows.Forms.ToolStripButton();
         this.scriptOutput = new System.Windows.Forms.TextBox();
         this.offsetCalibrationCheckBox = new System.Windows.Forms.CheckBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.ExpectedVersions.SuspendLayout();
         this.CalibrationInputs.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.CalibrationSettings.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.validRange)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cycleNum)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // ExpectedVersions
         // 
         this.ExpectedVersions.Controls.Add(this.bootloaderVersion);
         this.ExpectedVersions.Controls.Add(this.firmwareVersion);
         this.ExpectedVersions.Controls.Add(this.bootloaderLabel);
         this.ExpectedVersions.Controls.Add(this.firmwareLabel);
         this.ExpectedVersions.Location = new System.Drawing.Point(538, 12);
         this.ExpectedVersions.Name = "ExpectedVersions";
         this.ExpectedVersions.Size = new System.Drawing.Size(207, 144);
         this.ExpectedVersions.TabIndex = 0;
         this.ExpectedVersions.TabStop = false;
         this.ExpectedVersions.Text = "Expected Versions";
         this.ExpectedVersions.Enter += new System.EventHandler(this.groupBox1_Enter);
         // 
         // bootloaderVersion
         // 
         this.bootloaderVersion.Location = new System.Drawing.Point(110, 53);
         this.bootloaderVersion.MaxLength = 5;
         this.bootloaderVersion.Name = "bootloaderVersion";
         this.bootloaderVersion.Size = new System.Drawing.Size(91, 20);
         this.bootloaderVersion.TabIndex = 4;
         this.bootloaderVersion.Text = "6.00";
         this.bootloaderVersion.TextChanged += new System.EventHandler(this.bootloaderVersion_TextChanged);
         // 
         // firmwareVersion
         // 
         this.firmwareVersion.Location = new System.Drawing.Point(110, 23);
         this.firmwareVersion.MaxLength = 5;
         this.firmwareVersion.Name = "firmwareVersion";
         this.firmwareVersion.Size = new System.Drawing.Size(91, 20);
         this.firmwareVersion.TabIndex = 4;
         this.firmwareVersion.Text = "23.17";
         this.firmwareVersion.TextChanged += new System.EventHandler(this.firmwareVersion_TextChanged);
         // 
         // bootloaderLabel
         // 
         this.bootloaderLabel.AutoSize = true;
         this.bootloaderLabel.Location = new System.Drawing.Point(6, 52);
         this.bootloaderLabel.Name = "bootloaderLabel";
         this.bootloaderLabel.Size = new System.Drawing.Size(96, 13);
         this.bootloaderLabel.TabIndex = 1;
         this.bootloaderLabel.Text = "Bootloader Version";
         // 
         // firmwareLabel
         // 
         this.firmwareLabel.AutoSize = true;
         this.firmwareLabel.Location = new System.Drawing.Point(6, 26);
         this.firmwareLabel.Name = "firmwareLabel";
         this.firmwareLabel.Size = new System.Drawing.Size(87, 13);
         this.firmwareLabel.TabIndex = 0;
         this.firmwareLabel.Text = "Firmware Version";
         this.firmwareLabel.Click += new System.EventHandler(this.label4_Click);
         // 
         // CalibrationInputs
         // 
         this.CalibrationInputs.Controls.Add(this.label5);
         this.CalibrationInputs.Controls.Add(this.label4);
         this.CalibrationInputs.Controls.Add(this.label3);
         this.CalibrationInputs.Controls.Add(this.numericUpDown2);
         this.CalibrationInputs.Controls.Add(this.numericUpDown1);
         this.CalibrationInputs.Controls.Add(this.finalMode);
         this.CalibrationInputs.Controls.Add(this.initialMode);
         this.CalibrationInputs.Controls.Add(this.currentValue);
         this.CalibrationInputs.Controls.Add(this.currentModeLabel);
         this.CalibrationInputs.Controls.Add(this.voltageValue);
         this.CalibrationInputs.Controls.Add(this.currentRatio);
         this.CalibrationInputs.Controls.Add(this.pulseValue);
         this.CalibrationInputs.Controls.Add(this.voltageModeLabel);
         this.CalibrationInputs.Controls.Add(this.voltageRatio);
         this.CalibrationInputs.Controls.Add(this.currentModeComboBox);
         this.CalibrationInputs.Controls.Add(this.voltageModeComboBox);
         this.CalibrationInputs.Controls.Add(this.pulseRatio);
         this.CalibrationInputs.Controls.Add(this.pulseModeLabel);
         this.CalibrationInputs.Controls.Add(this.pulseModeComboBox);
         this.CalibrationInputs.Location = new System.Drawing.Point(12, 12);
         this.CalibrationInputs.Name = "CalibrationInputs";
         this.CalibrationInputs.Size = new System.Drawing.Size(320, 144);
         this.CalibrationInputs.TabIndex = 1;
         this.CalibrationInputs.TabStop = false;
         this.CalibrationInputs.Text = "Calibration Inputs";
         this.CalibrationInputs.Enter += new System.EventHandler(this.CalibrationInputs_Enter);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(205, 83);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(15, 13);
         this.label5.TabIndex = 24;
         this.label5.Text = "%";
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(205, 56);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(15, 13);
         this.label4.TabIndex = 23;
         this.label4.Text = "%";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(205, 26);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(15, 13);
         this.label3.TabIndex = 22;
         this.label3.Text = "%";
         // 
         // numericUpDown2
         // 
         this.numericUpDown2.Location = new System.Drawing.Point(73, 113);
         this.numericUpDown2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDown2.Name = "numericUpDown2";
         this.numericUpDown2.Size = new System.Drawing.Size(82, 20);
         this.numericUpDown2.TabIndex = 21;
         this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(226, 113);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
         this.numericUpDown1.TabIndex = 20;
         this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
         // 
         // finalMode
         // 
         this.finalMode.AutoSize = true;
         this.finalMode.Location = new System.Drawing.Point(161, 115);
         this.finalMode.Name = "finalMode";
         this.finalMode.Size = new System.Drawing.Size(59, 13);
         this.finalMode.TabIndex = 17;
         this.finalMode.Text = "Final Mode";
         // 
         // initialMode
         // 
         this.initialMode.AutoSize = true;
         this.initialMode.Location = new System.Drawing.Point(6, 115);
         this.initialMode.Name = "initialMode";
         this.initialMode.Size = new System.Drawing.Size(61, 13);
         this.initialMode.TabIndex = 15;
         this.initialMode.Text = "Initial Mode";
         this.initialMode.Click += new System.EventHandler(this.label2_Click_1);
         // 
         // currentValue
         // 
         this.currentValue.AutoSize = true;
         this.currentValue.Location = new System.Drawing.Point(81, 84);
         this.currentValue.Name = "currentValue";
         this.currentValue.Size = new System.Drawing.Size(46, 13);
         this.currentValue.TabIndex = 11;
         this.currentValue.Text = "20.0 mA";
         this.currentValue.Click += new System.EventHandler(this.currentValue_Click);
         // 
         // currentModeLabel
         // 
         this.currentModeLabel.AutoSize = true;
         this.currentModeLabel.Location = new System.Drawing.Point(6, 85);
         this.currentModeLabel.Name = "currentModeLabel";
         this.currentModeLabel.Size = new System.Drawing.Size(73, 13);
         this.currentModeLabel.TabIndex = 13;
         this.currentModeLabel.Text = "4-20mA Mode";
         this.currentModeLabel.Click += new System.EventHandler(this.currentModeLabel_Click);
         // 
         // voltageValue
         // 
         this.voltageValue.AutoSize = true;
         this.voltageValue.Location = new System.Drawing.Point(81, 56);
         this.voltageValue.Name = "voltageValue";
         this.voltageValue.Size = new System.Drawing.Size(38, 13);
         this.voltageValue.TabIndex = 10;
         this.voltageValue.Text = "10.0 V";
         this.voltageValue.Click += new System.EventHandler(this.voltageValue_Click);
         // 
         // currentRatio
         // 
         this.currentRatio.Location = new System.Drawing.Point(156, 82);
         this.currentRatio.MaxLength = 5;
         this.currentRatio.Name = "currentRatio";
         this.currentRatio.Size = new System.Drawing.Size(43, 20);
         this.currentRatio.TabIndex = 14;
         this.currentRatio.Text = "100";
         this.currentRatio.TextChanged += new System.EventHandler(this.currentPercent_TextChanged);
         // 
         // pulseValue
         // 
         this.pulseValue.AutoSize = true;
         this.pulseValue.Location = new System.Drawing.Point(81, 30);
         this.pulseValue.Name = "pulseValue";
         this.pulseValue.Size = new System.Drawing.Size(38, 13);
         this.pulseValue.TabIndex = 9;
         this.pulseValue.Text = "10.0 V";
         this.pulseValue.Click += new System.EventHandler(this.pulseValue_Click);
         // 
         // voltageModeLabel
         // 
         this.voltageModeLabel.AutoSize = true;
         this.voltageModeLabel.Location = new System.Drawing.Point(6, 56);
         this.voltageModeLabel.Name = "voltageModeLabel";
         this.voltageModeLabel.Size = new System.Drawing.Size(65, 13);
         this.voltageModeLabel.TabIndex = 12;
         this.voltageModeLabel.Text = "0-10V Mode";
         this.voltageModeLabel.Click += new System.EventHandler(this.voltageModeLabel_Click);
         // 
         // voltageRatio
         // 
         this.voltageRatio.Location = new System.Drawing.Point(156, 53);
         this.voltageRatio.MaxLength = 5;
         this.voltageRatio.Name = "voltageRatio";
         this.voltageRatio.Size = new System.Drawing.Size(43, 20);
         this.voltageRatio.TabIndex = 13;
         this.voltageRatio.Text = "100";
         this.voltageRatio.TextChanged += new System.EventHandler(this.voltageRatio_TextChanged);
         // 
         // currentModeComboBox
         // 
         this.currentModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.currentModeComboBox.FormattingEnabled = true;
         this.currentModeComboBox.Items.AddRange(new object[] {
            "4mA, 20mA",
            "0mA, 24mA"});
         this.currentModeComboBox.Location = new System.Drawing.Point(226, 81);
         this.currentModeComboBox.Name = "currentModeComboBox";
         this.currentModeComboBox.Size = new System.Drawing.Size(88, 21);
         this.currentModeComboBox.TabIndex = 12;
         this.currentModeComboBox.SelectedIndexChanged += new System.EventHandler(this.currentMode_SelectedIndexChanged);
         // 
         // voltageModeComboBox
         // 
         this.voltageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.voltageModeComboBox.FormattingEnabled = true;
         this.voltageModeComboBox.Items.AddRange(new object[] {
            "0V, 10V",
            "0V, 12V"});
         this.voltageModeComboBox.Location = new System.Drawing.Point(226, 53);
         this.voltageModeComboBox.Name = "voltageModeComboBox";
         this.voltageModeComboBox.Size = new System.Drawing.Size(88, 21);
         this.voltageModeComboBox.TabIndex = 11;
         this.voltageModeComboBox.SelectedIndexChanged += new System.EventHandler(this.voltageMode_SelectedIndexChanged);
         // 
         // pulseRatio
         // 
         this.pulseRatio.Location = new System.Drawing.Point(156, 23);
         this.pulseRatio.MaxLength = 5;
         this.pulseRatio.Name = "pulseRatio";
         this.pulseRatio.Size = new System.Drawing.Size(43, 20);
         this.pulseRatio.TabIndex = 10;
         this.pulseRatio.Text = "100";
         this.pulseRatio.TextChanged += new System.EventHandler(this.pulseRatio_TextChanged);
         // 
         // pulseModeLabel
         // 
         this.pulseModeLabel.AutoSize = true;
         this.pulseModeLabel.Location = new System.Drawing.Point(6, 26);
         this.pulseModeLabel.Name = "pulseModeLabel";
         this.pulseModeLabel.Size = new System.Drawing.Size(63, 13);
         this.pulseModeLabel.TabIndex = 9;
         this.pulseModeLabel.Text = "Pulse Mode";
         this.pulseModeLabel.Click += new System.EventHandler(this.label4_Click);
         // 
         // pulseModeComboBox
         // 
         this.pulseModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.pulseModeComboBox.FormattingEnabled = true;
         this.pulseModeComboBox.Items.AddRange(new object[] {
            "0V, 10V",
            "0V, 12V"});
         this.pulseModeComboBox.Location = new System.Drawing.Point(226, 23);
         this.pulseModeComboBox.Name = "pulseModeComboBox";
         this.pulseModeComboBox.Size = new System.Drawing.Size(88, 21);
         this.pulseModeComboBox.TabIndex = 19;
         this.pulseModeComboBox.SelectedIndexChanged += new System.EventHandler(this.pulseMode_SelectedIndexChanged);
         // 
         // CalibrationSettings
         // 
         this.CalibrationSettings.Controls.Add(this.label6);
         this.CalibrationSettings.Controls.Add(this.validRange);
         this.CalibrationSettings.Controls.Add(this.offsetNum);
         this.CalibrationSettings.Controls.Add(this.label2);
         this.CalibrationSettings.Controls.Add(this.cycleNum);
         this.CalibrationSettings.Controls.Add(this.recalibrateCheckBox);
         this.CalibrationSettings.Controls.Add(this.rangeLabel);
         this.CalibrationSettings.Controls.Add(this.cycleLabel);
         this.CalibrationSettings.Location = new System.Drawing.Point(338, 12);
         this.CalibrationSettings.Name = "CalibrationSettings";
         this.CalibrationSettings.Size = new System.Drawing.Size(194, 144);
         this.CalibrationSettings.TabIndex = 3;
         this.CalibrationSettings.TabStop = false;
         this.CalibrationSettings.Text = "Calibration Settings";
         this.CalibrationSettings.Enter += new System.EventHandler(this.CalibrationSettings_Enter);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(173, 85);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(15, 13);
         this.label6.TabIndex = 25;
         this.label6.Text = "%";
         // 
         // validRange
         // 
         this.validRange.Location = new System.Drawing.Point(97, 81);
         this.validRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.validRange.Name = "validRange";
         this.validRange.Size = new System.Drawing.Size(70, 20);
         this.validRange.TabIndex = 16;
         this.validRange.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.validRange.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
         // 
         // offsetNum
         // 
         this.offsetNum.Location = new System.Drawing.Point(97, 54);
         this.offsetNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.offsetNum.Name = "offsetNum";
         this.offsetNum.Size = new System.Drawing.Size(91, 20);
         this.offsetNum.TabIndex = 15;
         this.offsetNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
         this.offsetNum.ValueChanged += new System.EventHandler(this.offsetNum_ValueChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(7, 56);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(86, 13);
         this.label2.TabIndex = 14;
         this.label2.Text = "Averaging Offset";
         this.label2.Click += new System.EventHandler(this.label2_Click_2);
         // 
         // cycleNum
         // 
         this.cycleNum.Location = new System.Drawing.Point(97, 24);
         this.cycleNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.cycleNum.Name = "cycleNum";
         this.cycleNum.Size = new System.Drawing.Size(91, 20);
         this.cycleNum.TabIndex = 12;
         this.cycleNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
         this.cycleNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // recalibrateCheckBox
         // 
         this.recalibrateCheckBox.AutoSize = true;
         this.recalibrateCheckBox.Location = new System.Drawing.Point(10, 109);
         this.recalibrateCheckBox.Name = "recalibrateCheckBox";
         this.recalibrateCheckBox.Size = new System.Drawing.Size(110, 17);
         this.recalibrateCheckBox.TabIndex = 9;
         this.recalibrateCheckBox.Text = "Force Recalibrate";
         this.recalibrateCheckBox.UseVisualStyleBackColor = true;
         this.recalibrateCheckBox.CheckedChanged += new System.EventHandler(this.recalibrateCheckBox_CheckedChanged);
         // 
         // rangeLabel
         // 
         this.rangeLabel.AutoSize = true;
         this.rangeLabel.Location = new System.Drawing.Point(7, 85);
         this.rangeLabel.Name = "rangeLabel";
         this.rangeLabel.Size = new System.Drawing.Size(65, 13);
         this.rangeLabel.TabIndex = 1;
         this.rangeLabel.Text = "Valid Range";
         this.rangeLabel.Click += new System.EventHandler(this.rangeLabel_Click);
         // 
         // cycleLabel
         // 
         this.cycleLabel.AutoSize = true;
         this.cycleLabel.Location = new System.Drawing.Point(7, 31);
         this.cycleLabel.Name = "cycleLabel";
         this.cycleLabel.Size = new System.Drawing.Size(84, 13);
         this.cycleLabel.TabIndex = 0;
         this.cycleLabel.Text = "Averaging Cycle";
         // 
         // scriptPath
         // 
         this.scriptPath.Location = new System.Drawing.Point(868, 35);
         this.scriptPath.Name = "scriptPath";
         this.scriptPath.Size = new System.Drawing.Size(265, 20);
         this.scriptPath.TabIndex = 0;
         this.scriptPath.TextChanged += new System.EventHandler(this.scriptPath_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(759, 59);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(0, 13);
         this.label1.TabIndex = 1;
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // scriptPathLabel
         // 
         this.scriptPathLabel.AutoSize = true;
         this.scriptPathLabel.Location = new System.Drawing.Point(751, 38);
         this.scriptPathLabel.Name = "scriptPathLabel";
         this.scriptPathLabel.Size = new System.Drawing.Size(111, 13);
         this.scriptPathLabel.TabIndex = 2;
         this.scriptPathLabel.Text = "Calibration Script Path";
         this.scriptPathLabel.Click += new System.EventHandler(this.label2_Click);
         // 
         // postScriptLabel
         // 
         this.postScriptLabel.AutoSize = true;
         this.postScriptLabel.Location = new System.Drawing.Point(751, 64);
         this.postScriptLabel.Name = "postScriptLabel";
         this.postScriptLabel.Size = new System.Drawing.Size(110, 13);
         this.postScriptLabel.TabIndex = 4;
         this.postScriptLabel.Text = "Post-Calibration Script";
         this.postScriptLabel.Click += new System.EventHandler(this.postScriptLabel_Click);
         // 
         // scipthPathBtn
         // 
         this.scipthPathBtn.Location = new System.Drawing.Point(1139, 33);
         this.scipthPathBtn.Name = "scipthPathBtn";
         this.scipthPathBtn.Size = new System.Drawing.Size(75, 23);
         this.scipthPathBtn.TabIndex = 5;
         this.scipthPathBtn.Text = "Browse";
         this.scipthPathBtn.UseVisualStyleBackColor = true;
         this.scipthPathBtn.Click += new System.EventHandler(this.button1_Click);
         // 
         // postScript
         // 
         this.postScript.Location = new System.Drawing.Point(868, 61);
         this.postScript.Name = "postScript";
         this.postScript.Size = new System.Drawing.Size(265, 20);
         this.postScript.TabIndex = 6;
         this.postScript.TextChanged += new System.EventHandler(this.postScript_TextChanged);
         // 
         // postScriptBtn
         // 
         this.postScriptBtn.Location = new System.Drawing.Point(1139, 59);
         this.postScriptBtn.Name = "postScriptBtn";
         this.postScriptBtn.Size = new System.Drawing.Size(75, 23);
         this.postScriptBtn.TabIndex = 4;
         this.postScriptBtn.Text = "Browse";
         this.postScriptBtn.UseVisualStyleBackColor = true;
         this.postScriptBtn.Click += new System.EventHandler(this.postScriptBtn_Click);
         // 
         // continuousModeCheckBox
         // 
         this.continuousModeCheckBox.AutoSize = true;
         this.continuousModeCheckBox.Location = new System.Drawing.Point(753, 91);
         this.continuousModeCheckBox.Name = "continuousModeCheckBox";
         this.continuousModeCheckBox.Size = new System.Drawing.Size(109, 17);
         this.continuousModeCheckBox.TabIndex = 7;
         this.continuousModeCheckBox.Text = "Continuous Mode";
         this.continuousModeCheckBox.UseVisualStyleBackColor = true;
         this.continuousModeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
         // 
         // moreVariableBtn
         // 
         this.moreVariableBtn.Location = new System.Drawing.Point(868, 87);
         this.moreVariableBtn.Name = "moreVariableBtn";
         this.moreVariableBtn.Size = new System.Drawing.Size(117, 23);
         this.moreVariableBtn.TabIndex = 8;
         this.moreVariableBtn.Text = "More Variables";
         this.moreVariableBtn.UseVisualStyleBackColor = true;
         this.moreVariableBtn.Click += new System.EventHandler(this.button3_Click);
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationButton,
            this.saveConfigurationButton,
            this.saveConfigurationAsButton,
            this.goPauseButton});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(1226, 25);
         this.toolStrip1.TabIndex = 10;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // openConfigurationButton
         // 
         this.openConfigurationButton.Image = global::ModbusCommanderProductionPlugin.Properties.Resources.folder;
         this.openConfigurationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.openConfigurationButton.Name = "openConfigurationButton";
         this.openConfigurationButton.Size = new System.Drawing.Size(133, 22);
         this.openConfigurationButton.Text = "Open Configuration";
         this.openConfigurationButton.Click += new System.EventHandler(this.openConfigurationButton_Click);
         // 
         // saveConfigurationButton
         // 
         this.saveConfigurationButton.Image = global::ModbusCommanderProductionPlugin.Properties.Resources.disk;
         this.saveConfigurationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveConfigurationButton.Name = "saveConfigurationButton";
         this.saveConfigurationButton.Size = new System.Drawing.Size(128, 22);
         this.saveConfigurationButton.Text = "Save Configuration";
         this.saveConfigurationButton.Click += new System.EventHandler(this.saveConfigurationButton_Click);
         // 
         // saveConfigurationAsButton
         // 
         this.saveConfigurationAsButton.Image = global::ModbusCommanderProductionPlugin.Properties.Resources.disk;
         this.saveConfigurationAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveConfigurationAsButton.Name = "saveConfigurationAsButton";
         this.saveConfigurationAsButton.Size = new System.Drawing.Size(144, 22);
         this.saveConfigurationAsButton.Text = "Save Configuration As";
         this.saveConfigurationAsButton.Click += new System.EventHandler(this.saveConfigurationAsButton_Click);
         // 
         // goPauseButton
         // 
         this.goPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("goPauseButton.Image")));
         this.goPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.goPauseButton.Name = "goPauseButton";
         this.goPauseButton.Size = new System.Drawing.Size(109, 22);
         this.goPauseButton.Text = "Run Calibration";
         this.goPauseButton.Click += new System.EventHandler(this.goPauseButton_Click);
         // 
         // scriptOutput
         // 
         this.scriptOutput.BackColor = System.Drawing.Color.Black;
         this.scriptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.scriptOutput.ForeColor = System.Drawing.Color.White;
         this.scriptOutput.Location = new System.Drawing.Point(12, 162);
         this.scriptOutput.Multiline = true;
         this.scriptOutput.Name = "scriptOutput";
         this.scriptOutput.ReadOnly = true;
         this.scriptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.scriptOutput.Size = new System.Drawing.Size(1202, 524);
         this.scriptOutput.TabIndex = 12;
         this.scriptOutput.Visible = false;
         this.scriptOutput.TextChanged += new System.EventHandler(this.scriptOutput_TextChanged);
         // 
         // offsetCalibrationCheckBox
         // 
         this.offsetCalibrationCheckBox.AutoSize = true;
         this.offsetCalibrationCheckBox.Checked = true;
         this.offsetCalibrationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
         this.offsetCalibrationCheckBox.Location = new System.Drawing.Point(753, 114);
         this.offsetCalibrationCheckBox.Name = "offsetCalibrationCheckBox";
         this.offsetCalibrationCheckBox.Size = new System.Drawing.Size(106, 17);
         this.offsetCalibrationCheckBox.TabIndex = 13;
         this.offsetCalibrationCheckBox.Text = "Offset Calibration";
         this.offsetCalibrationCheckBox.UseVisualStyleBackColor = true;
         this.offsetCalibrationCheckBox.CheckedChanged += new System.EventHandler(this.offsetCalibrationCheckBox_CheckedChanged);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
         this.statusStrip1.Location = new System.Drawing.Point(0, 689);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(1226, 22);
         this.statusStrip1.TabIndex = 14;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // statusLabel
         // 
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(67, 17);
         this.statusLabel.Text = "StatusLabel";
         // 
         // InputCardCalibrationForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1226, 711);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.offsetCalibrationCheckBox);
         this.Controls.Add(this.scriptOutput);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.moreVariableBtn);
         this.Controls.Add(this.CalibrationSettings);
         this.Controls.Add(this.continuousModeCheckBox);
         this.Controls.Add(this.postScriptBtn);
         this.Controls.Add(this.CalibrationInputs);
         this.Controls.Add(this.postScript);
         this.Controls.Add(this.ExpectedVersions);
         this.Controls.Add(this.scipthPathBtn);
         this.Controls.Add(this.postScriptLabel);
         this.Controls.Add(this.scriptPath);
         this.Controls.Add(this.scriptPathLabel);
         this.Controls.Add(this.label1);
         this.Name = "InputCardCalibrationForm";
         this.Text = "InputCardCalibrationForm";
         this.ExpectedVersions.ResumeLayout(false);
         this.ExpectedVersions.PerformLayout();
         this.CalibrationInputs.ResumeLayout(false);
         this.CalibrationInputs.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.CalibrationSettings.ResumeLayout(false);
         this.CalibrationSettings.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.validRange)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cycleNum)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ExpectedVersions;
      private System.Windows.Forms.GroupBox CalibrationInputs;
      private System.Windows.Forms.GroupBox CalibrationSettings;
      private System.Windows.Forms.TextBox scriptPath;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label scriptPathLabel;
      private System.Windows.Forms.Label postScriptLabel;
      private System.Windows.Forms.Button scipthPathBtn;
      private System.Windows.Forms.TextBox postScript;
      private System.Windows.Forms.Button postScriptBtn;
      private System.Windows.Forms.CheckBox continuousModeCheckBox;
      private System.Windows.Forms.Button moreVariableBtn;
      private System.Windows.Forms.Label bootloaderLabel;
      private System.Windows.Forms.Label firmwareLabel;
      private System.Windows.Forms.TextBox firmwareVersion;
      private System.Windows.Forms.CheckBox recalibrateCheckBox;
      private System.Windows.Forms.Label rangeLabel;
      private System.Windows.Forms.Label cycleLabel;
      private System.Windows.Forms.TextBox pulseRatio;
      private System.Windows.Forms.Label pulseModeLabel;
      private System.Windows.Forms.ComboBox pulseModeComboBox;
      private System.Windows.Forms.ComboBox currentModeComboBox;
      private System.Windows.Forms.ComboBox voltageModeComboBox;
      private System.Windows.Forms.TextBox currentRatio;
      private System.Windows.Forms.TextBox voltageRatio;
      private System.Windows.Forms.Label pulseValue;
      private System.Windows.Forms.Label voltageValue;
      private System.Windows.Forms.Label currentValue;
      private System.Windows.Forms.Label currentModeLabel;
      private System.Windows.Forms.Label voltageModeLabel;
      private System.Windows.Forms.NumericUpDown cycleNum;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton openConfigurationButton;
      private System.Windows.Forms.ToolStripButton saveConfigurationButton;
      private System.Windows.Forms.ToolStripButton saveConfigurationAsButton;
      private System.Windows.Forms.ToolStripButton goPauseButton;
      private System.Windows.Forms.TextBox scriptOutput;
      private System.Windows.Forms.Label initialMode;
      private System.Windows.Forms.Label finalMode;
      private System.Windows.Forms.NumericUpDown numericUpDown2;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.NumericUpDown offsetNum;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown validRange;
      private System.Windows.Forms.CheckBox offsetCalibrationCheckBox;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel statusLabel;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox bootloaderVersion;
   }
}