using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsSystem625
{

   
    public partial class FormOptions : MetroForm
    {

        //public static Form1.SerialControlLinesIO SerialControlLinesManagerLocal;


        //static int ControlLine7ToggleButton = 0;
        public FormOptions()
        {
            InitializeComponent();
            Form1.AcquisitionLogic AcquisitionControl = Form1.AcquisitionLogic.Instance;
            try
            {
                //SerialControlLinesManagerLocal = new Form1.SerialControlLinesIO();

                //SerialControlLinesManagerLocal.initSerialIO();
                AcquisitionControl.SetControlLines(Form1.SerialIOControlLinesManager, false, false);

            }
            catch (Exception Ex)
            {

            }

            if(Properties.Settings.Default.OutputPin7==true)
            {
                mrbModbus.Checked = false;
                mrbCL7.Checked = true;
            }
            else
            {
                mrbModbus.Checked = true;
                mrbCL7.Checked = false;

            }

            //read the settings for the Temperature Sensor type: 
            if (Properties.Settings.Default.TemperatureSensorType.Contains("T60"))
            {
                mrbTemperatureSensorTypeT60.Checked = true;
                mrbTemperatureSensorType110S.Checked= false;
            }
            else
            {
                mrbTemperatureSensorTypeT60.Checked = false;
                mrbTemperatureSensorType110S.Checked = true;

            }




            int value = Properties.Settings.Default.FWMC;


            //read the settings and display in the appropriate textboxes
            tbMetroFWMC.Text = Properties.Settings.Default.FWMC.ToString();
            tbMetroFWHC.Text = Properties.Settings.Default.FWHC.ToString();
            tbMetroFWHK.Text = Properties.Settings.Default.FWHK.ToString();

            tbMetroDMC.Text = Properties.Settings.Default.DMC.ToString();
            tbMetroDHC.Text = Properties.Settings.Default.DHC.ToString();
            tbMetroNozzleMC.Text = Properties.Settings.Default.NozzleMC.ToString();
            tbMetroNozzleHC.Text = Properties.Settings.Default.NozzleHC.ToString();
            tbMetroTapeMC.Text = Properties.Settings.Default.TapeMC.ToString();
            tbMetroTapeHC.Text = Properties.Settings.Default.TapeHC.ToString();

            tbmTubeTempError.Text = Properties.Settings.Default.TubeTempErrorTrigger.ToString();
            tbmTubeTempWarning.Text = Properties.Settings.Default.TubeTempWarningTrigger.ToString();

            mtbFlowError.Text = Properties.Settings.Default.FlowError.ToString("F1");
            mtbFlowWarning.Text = Properties.Settings.Default.FlowWarning.ToString("F1");

            mtbSampleFlowRate.Text = Properties.Settings.Default.RunModeFlow.ToString("F1");

        }







        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ControlLine7ToggleButton = 0;
            mbCL7Toggle.Visible = false;
            mbCL7Toggle.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //ControlLine7ToggleButton = 1;
            mbCL7Toggle.Visible = true;
            mbCL7Toggle.Text = "Test:  Turn CL7 ON";
        }

        private void mbOptionsConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                mbCL7Toggle.Visible = false;
                mbCL7Toggle.Text = "Turn CL7 ON";
                //bhc 07.08.2019 turn off the CL7 line
                //SerialControlLinesManagerLocal.ClrOutputPin7();

                Form1.AcquisitionLogic AcquisitionControl = Form1.AcquisitionLogic.Instance;
                AcquisitionControl.SetControlLines(Form1.SerialIOControlLinesManager, false, false);

                if(mrbTemperatureSensorType110S.Checked == true)
                {
                    Properties.Settings.Default.TemperatureSensorType = "110S";
                }
                else if(mrbTemperatureSensorTypeT60.Checked == true)
                {
                    Properties.Settings.Default.TemperatureSensorType = "T60";
                }



                if (mrbModbus.Checked == true)
                {
                    Properties.Settings.Default.OutputPin7 = false;
                    //Form1.SerialControlLinesIO SerialIOControlLinesManager = new Form1.SerialControlLinesIO();
                    //SerialIOControlLinesManager.CloseSerialPort();
                    //SerialIOControlLinesManager.initSerialIO();  //init sets up the comport and use the nmodbus comport number.
                    //nModbusOperations.initialize(mbComport, 9600, out xactHoldingRegisters);
                    //AcquisitionControl.setDataStore(xactHoldingRegisters);

                }
                else
                {
                    Properties.Settings.Default.OutputPin7 = true;

                    //init control lines comport class on the Modbus comport
                    //Form1.SerialControlLinesIO SerialIOControlLinesManager = new Form1.SerialControlLinesIO();
                    //SerialIOControlLinesManager.CloseSerialPort();

                    //SerialIOControlLinesManager.initSerialIO();  //init sets up the comport and use the nmodbus comport number.
                    //SerialIOControlLinesManager.ClrOutputPin4();
                    //SerialIOControlLinesManager.ClrOutputPin7();

                }



                //reset comport actions

                //read the values for move and hold current
                int junk;
                junk = Convert.ToInt32(tbMetroFWMC.Text);
                Properties.Settings.Default.FWMC = Convert.ToInt32(tbMetroFWMC.Text);
                Properties.Settings.Default.FWHC = Convert.ToInt32(tbMetroFWHC.Text);
                Properties.Settings.Default.FWHK = Convert.ToInt16(tbMetroFWHK.Text);

                Properties.Settings.Default.DMC = Convert.ToInt32(tbMetroDMC.Text);
                Properties.Settings.Default.DHC = Convert.ToInt32(tbMetroDHC.Text);
                Properties.Settings.Default.NozzleMC = Convert.ToInt32(tbMetroNozzleMC.Text);
                Properties.Settings.Default.NozzleHC = Convert.ToInt32(tbMetroNozzleHC.Text);
                Properties.Settings.Default.TapeMC = Convert.ToInt32(tbMetroTapeMC.Text);
                Properties.Settings.Default.TapeHC = Convert.ToInt32(tbMetroTapeHC.Text);

                Properties.Settings.Default.TubeTempErrorTrigger = Convert.ToDouble(tbmTubeTempError.Text);
                Properties.Settings.Default.TubeTempWarningTrigger = Convert.ToDouble(tbmTubeTempWarning.Text);

                
                //this logic uses in-line try catch to set values in case any are invalid
                try
                {
                    Properties.Settings.Default.FlowError= Convert.ToDouble(mtbFlowError.Text);
                }
                catch
                {
                    Properties.Settings.Default.FlowError = 5.0;
                    mtbFlowError.Text = "5.0";
                }
                try
                {
                    Properties.Settings.Default.FlowWarning = Convert.ToDouble(mtbFlowWarning.Text);
                }
                catch
                {
                    Properties.Settings.Default.FlowWarning = 10.0;
                    mtbFlowWarning.Text = "10.0";
                }

                try
                {
                    Properties.Settings.Default.RunModeFlow= Convert.ToDouble(mtbSampleFlowRate.Text);
                    if(Properties.Settings.Default.RunModeFlow>19.5)
                    {
                        Logger.WriteInternalLogFile("Sample Flow Rate > 19.5 defaulting to 19.5 L/min");
                        Properties.Settings.Default.RunModeFlow = 19.5;
                        mtbSampleFlowRate.Text = "19.5";
                    }
                    if (Properties.Settings.Default.RunModeFlow <=0)
                    {
                        Logger.WriteInternalLogFile("Sample Flow Rate <=0   defaulting to 16.7 L/min");
                        Properties.Settings.Default.RunModeFlow = 16.7;
                        mtbSampleFlowRate.Text = "16.7";
                    }
                }
                catch
                {
                    Logger.WriteInternalLogFile("Unable to convert input value for sample flow rate--defaulting to 16.7 L/min");
                    Properties.Settings.Default.RunModeFlow = 16.7;
                    mtbSampleFlowRate.Text = "16.7";
                }



            }



            catch (Exception Ex)
            {
                Logger.WriteInternalLogFile("Error saving options.  Ex = " + Ex.ToString());

            }
            finally
            {
                this.Close();

            }
        }


        private void mbCL7Toggle_Click(object sender, EventArgs e)
        {
            try
            {
                //ControlLine7ToggleButton = 1;
                //mbCL7Toggle.Visible = true;
                if (mbCL7Toggle.Text.Contains("Turn CL7 ON"))
                {

                    //turn on the pin

                    //SerialIOControlLinesManager.ClrOutputPin7();
                    //toggle the text
                    Form1.AcquisitionLogic AcquisitionControl = Form1.AcquisitionLogic.Instance;
                    AcquisitionControl.SetControlLines(Form1.SerialIOControlLinesManager, true, false);

                    mbCL7Toggle.Text = "Test:  Turn CL7 OFF";
                }
                else
                {
                    //turn off the pin
                    //SerialControlLinesManagerLocal.ClrOutputPin7();
                    Form1.AcquisitionLogic AcquisitionControl = Form1.AcquisitionLogic.Instance;
                    AcquisitionControl.SetControlLines(Form1.SerialIOControlLinesManager, false, false);


                    //toggle the text
                    mbCL7Toggle.Text = "Test:  Turn CL7 ON";

                }
            }
            catch(Exception Ex)
            {

            }


        }
    }
}
