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
using System.IO;


namespace WindowsSystem625
{
    public partial class FormStatus : MetroForm
    {
        public FormStatus()
        {
            InitializeComponent();
            //DateTime mdtStart;
            //DateTime mdtEnd; 
            if (DataContainer.displayItem==0)
            {
                rtbStatusInfo.Clear();
                string fText = "No Warnings or Errors.";
                rtbStatusInfo.SelectionStart = 0;  // or wherever you want to insert in this rtb
                rtbStatusInfo.SelectionLength = 0;
                rtbStatusInfo.SelectionFont = new System.Drawing.Font("Tahoma", 14);
                rtbStatusInfo.SelectedText = fText;
            }
            else if(DataContainer.displayItem==1)
            {

                try
                {

                    rtbStatusInfo.Clear();

                    //////get start time
                    ////DateTime Start = DateTime.Now.AddDays(-1);
                    //////get end time
                    ////DateTime End = DateTime.Now.AddDays(+1);

                    ////var directory = new DirectoryInfo("c:/TEMP/");
                    ////DateTime from_date = Start;
                    ////DateTime to_date = End;

                    ////var fileList = directory.GetFiles()
                    ////    .Where(fileVal => /*fileVal.LastWriteTime >= from_date &&*/ fileVal.LastWriteTime <= to_date)
                    ////    .OrderByDescending(d => d.CreationTime)
                    ////    .ToList();

                    ////List<string> filesToParse = new List<string>();
                    ////filesToParse.Clear();

                    ////foreach (var fileName in /*fileEntries*/ fileList)
                    ////{
                    ////    if (fileName.Name.Contains("Warning"))
                    ////    {
                    ////        filesToParse.Add(fileName.Name);
                    ////    }
                    ////    else
                    ////    {
                    ////        continue;
                    ////    }
                    ////}


                    ////int filesToParseIndex = 0;
                    ////string value = filesToParse[filesToParseIndex];
                    ////string path = "c:/TEMP/";

                    ////System.IO.StreamReader sr = new System.IO.StreamReader(path + value);


                    ////string fText = sr.ReadToEnd();
                    string fText = DataContainer.StatusDisplayWarningMessage;

                    rtbStatusInfo.SelectionStart = 0;  // or wherever you want to insert in this rtb
                    rtbStatusInfo.SelectionLength = 0;
                    rtbStatusInfo.SelectionFont = new System.Drawing.Font("Tahoma", 14);
                    rtbStatusInfo.SelectedText = fText;

                    ////sr.Close();

                    mbResetWarnings.Visible = true;
                }
                catch (Exception Ex)
                {
                    Logger.WriteInternalLogFile("Exception in Data view.  Ex = " + Ex.ToString());
                }






            }
            else if (DataContainer.displayItem == 2)
            {

                try
                {

                    rtbStatusInfo.Clear();

                    //////get start time
                    ////DateTime Start = DateTime.Now.AddDays(-1);
                    //////get end time
                    ////DateTime End = DateTime.Now.AddDays(+1);

                    ////var directory = new DirectoryInfo("c:/TEMP/");
                    ////DateTime from_date = Start;
                    ////DateTime to_date = End;

                    ////var fileList = directory.GetFiles()
                    ////    .Where(fileVal => /*fileVal.LastWriteTime >= from_date &&*/ fileVal.LastWriteTime <= to_date)
                    ////    .OrderByDescending(d => d.CreationTime)
                    ////    .ToList();

                    ////List<string> filesToParse = new List<string>();
                    ////filesToParse.Clear();

                    ////foreach (var fileName in /*fileEntries*/ fileList)
                    ////{
                    ////    if (fileName.Name.Contains("Error"))
                    ////    {
                    ////        filesToParse.Add(fileName.Name);
                    ////    }
                    ////    else
                    ////    {
                    ////        continue;
                    ////    }
                    ////}


                    ////int filesToParseIndex = 0;
                    ////string value = filesToParse[filesToParseIndex];
                    ////string path = "c:/TEMP/";

                    ////System.IO.StreamReader sr = new System.IO.StreamReader(path + value);


                    //string fText = sr.ReadToEnd();
                    string fText = DataContainer.StatusDisplayErrorMessage;

                    rtbStatusInfo.SelectionStart = 0;  // or wherever you want to insert in this rtb
                    rtbStatusInfo.SelectionLength = 0;
                    rtbStatusInfo.SelectionFont = new System.Drawing.Font("Tahoma", 14);
                    rtbStatusInfo.SelectedText = fText;

                    ////sr.Close();
                }
                catch (Exception Ex)
                {
                    Logger.WriteInternalLogFile("Exception in Data view.  Ex = " + Ex.ToString());
                }

            }




        }

        private void mbStatusClose_Click(object sender, EventArgs e)
        {
            mbResetWarnings.Visible = false;
            this.Close();
        }

        private void mbResetWarnings_Click(object sender, EventArgs e)
        {


            
            if (DataContainer.displayItem==1)
            {
                //reset the yellow display to green if running or gray if not running
                DataContainer.displayItem = 10;

                //metroStatusButton.BackColor.R == 240 && metroStatusButton.BackColor.G == 240 && metroStatusButton.BackColor.B == 240
                //metroStatusButton.BackColor == Color.Green
                DataContainer.StatusDisplayWarningMessage = String.Empty;
            }
        }
    }
}
