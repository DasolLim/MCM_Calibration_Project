# MCMCalibrationProject

![image](https://github.com/DasolLim/MCMCalibrationProject/assets/92288227/f3fc9ee7-62be-4368-8132-672bb52455a8)

## Description:
Elkor Technologies Modbus Commander Input Card Calibration Plugin Project

## Language: 
LUA and C#

## Part 1)
### Objective:
Create a script that calibrates Elkor Technologies newest product.

### Tasks:
Implement a function that convert C# variables to LUA.
Develop LUA script to operate Modbus Commander, MCM, Input Card Calibration Form functionalities/features such as Force Recalibrate, Continuous Mode, and Offset Calibration.
Implement storing and utilizing dynamic values from different MCM files/pages.
For example: mode, channel, firmware, bootloader, build stage, and card connection.
Calibrate and design an effective card status indicator for readability and understanding.
Debug and test DAC connection by implementing existing DAC library.
Optimize LUA script with delays to prevent corrupted calibration process.
Implement conditional statements and loop to catch or flag all errors.
Implement mathematical operations for calibration outputs such as multiplication, division, sum, average, and range.
Implement offset function that modifies DAC output to match the expected value.
Design a table display at the end of the code for calibrated output values

### Note:
No permission to share LUA Input card calibration project due to security issues regarding internal/proprietary register that are not publicly accessible.

## Part 2)
### Objective:
Create a Modbus Commander Production Plugin by designing and developing a GUI application to run LUA script

### Task:
Implement function that set and get variables from C# to LUA using LUA API in InputCardCalibrationForm.cs
Optimize the code to connect LUA script with Modbus Commander
Design GUI application with indicated specifications within InputCardCalibrationForm.Designer.cs file
Display GUI application in InputCardCalibrationForm.cs[Design]
Implement code to run LUA script within GUI display
Implement LUA functions such as Continuous Mode, Post-Calibration Script, and Run Calibration to Modbus Commander
Implement open, save, and save as Configuration functionalities to GUI application
Load dacCalibration.csv and write to DAC


### Files:
InputCardCalibrationForm.cs

InputCardCalibrationForm.Designer.cs

InputCardCalibrationForm.cs[Design]

InputCardCalibrationForm.resx

