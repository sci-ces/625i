namespace WindowsSystem625
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.metroLabel93 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mrbCL7 = new System.Windows.Forms.RadioButton();
            this.mrbModbus = new System.Windows.Forms.RadioButton();
            this.mbCL7Toggle = new MetroFramework.Controls.MetroButton();
            this.mbOptionsConfirm = new MetroFramework.Controls.MetroButton();
            this.metroPanel16 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbMetroFWHK = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroTapeHC = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroTapeMC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel66 = new MetroFramework.Controls.MetroLabel();
            this.tbMetroNozzleHC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel54 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel53 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel52 = new MetroFramework.Controls.MetroLabel();
            this.tbMetroNozzleMC = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroDHC = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroDMC = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroFWHC = new MetroFramework.Controls.MetroTextBox();
            this.tbMetroFWMC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel43 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel49 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel50 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel51 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbmTubeTempWarning = new MetroFramework.Controls.MetroTextBox();
            this.tbmTubeTempError = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mrbTemperatureSensorTypeT60 = new System.Windows.Forms.RadioButton();
            this.mrbTemperatureSensorType110S = new System.Windows.Forms.RadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtbFlowWarning = new MetroFramework.Controls.MetroTextBox();
            this.mtbFlowError = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtbSampleFlowRate = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.metroPanel16.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel93
            // 
            this.metroLabel93.AutoSize = true;
            this.metroLabel93.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel93.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel93.Location = new System.Drawing.Point(34, 14);
            this.metroLabel93.Name = "metroLabel93";
            this.metroLabel93.Size = new System.Drawing.Size(137, 25);
            this.metroLabel93.TabIndex = 27;
            this.metroLabel93.Text = "J1 Port Output";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mrbCL7);
            this.panel1.Controls.Add(this.mrbModbus);
            this.panel1.Controls.Add(this.mbCL7Toggle);
            this.panel1.Controls.Add(this.metroLabel93);
            this.panel1.Location = new System.Drawing.Point(633, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 208);
            this.panel1.TabIndex = 29;
            // 
            // mrbCL7
            // 
            this.mrbCL7.AutoSize = true;
            this.mrbCL7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrbCL7.Location = new System.Drawing.Point(39, 81);
            this.mrbCL7.Name = "mrbCL7";
            this.mrbCL7.Size = new System.Drawing.Size(144, 28);
            this.mrbCL7.TabIndex = 29;
            this.mrbCL7.Text = "Control Line 7";
            this.mrbCL7.UseVisualStyleBackColor = true;
            this.mrbCL7.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // mrbModbus
            // 
            this.mrbModbus.AutoSize = true;
            this.mrbModbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrbModbus.Location = new System.Drawing.Point(39, 49);
            this.mrbModbus.Name = "mrbModbus";
            this.mrbModbus.Size = new System.Drawing.Size(97, 28);
            this.mrbModbus.TabIndex = 28;
            this.mrbModbus.Text = "Modbus";
            this.mrbModbus.UseVisualStyleBackColor = true;
            this.mrbModbus.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mbCL7Toggle
            // 
            this.mbCL7Toggle.Location = new System.Drawing.Point(24, 124);
            this.mbCL7Toggle.Name = "mbCL7Toggle";
            this.mbCL7Toggle.Size = new System.Drawing.Size(147, 49);
            this.mbCL7Toggle.TabIndex = 30;
            this.mbCL7Toggle.UseSelectable = true;
            this.mbCL7Toggle.Click += new System.EventHandler(this.mbCL7Toggle_Click);
            // 
            // mbOptionsConfirm
            // 
            this.mbOptionsConfirm.Location = new System.Drawing.Point(677, 469);
            this.mbOptionsConfirm.Name = "mbOptionsConfirm";
            this.mbOptionsConfirm.Size = new System.Drawing.Size(147, 49);
            this.mbOptionsConfirm.TabIndex = 29;
            this.mbOptionsConfirm.Text = "Confirm";
            this.mbOptionsConfirm.UseSelectable = true;
            this.mbOptionsConfirm.Click += new System.EventHandler(this.mbOptionsConfirm_Click);
            // 
            // metroPanel16
            // 
            this.metroPanel16.Controls.Add(this.metroLabel1);
            this.metroPanel16.Controls.Add(this.tbMetroFWHK);
            this.metroPanel16.Controls.Add(this.tbMetroTapeHC);
            this.metroPanel16.Controls.Add(this.tbMetroTapeMC);
            this.metroPanel16.Controls.Add(this.metroLabel66);
            this.metroPanel16.Controls.Add(this.tbMetroNozzleHC);
            this.metroPanel16.Controls.Add(this.metroLabel54);
            this.metroPanel16.Controls.Add(this.metroLabel53);
            this.metroPanel16.Controls.Add(this.metroLabel52);
            this.metroPanel16.Controls.Add(this.tbMetroNozzleMC);
            this.metroPanel16.Controls.Add(this.tbMetroDHC);
            this.metroPanel16.Controls.Add(this.tbMetroDMC);
            this.metroPanel16.Controls.Add(this.tbMetroFWHC);
            this.metroPanel16.Controls.Add(this.tbMetroFWMC);
            this.metroPanel16.Controls.Add(this.metroLabel43);
            this.metroPanel16.Controls.Add(this.metroLabel49);
            this.metroPanel16.Controls.Add(this.metroLabel50);
            this.metroPanel16.Controls.Add(this.metroLabel51);
            this.metroPanel16.HorizontalScrollbarBarColor = true;
            this.metroPanel16.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel16.HorizontalScrollbarSize = 10;
            this.metroPanel16.Location = new System.Drawing.Point(51, 75);
            this.metroPanel16.Name = "metroPanel16";
            this.metroPanel16.Size = new System.Drawing.Size(274, 299);
            this.metroPanel16.TabIndex = 30;
            this.metroPanel16.VerticalScrollbarBarColor = true;
            this.metroPanel16.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel16.VerticalScrollbarSize = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(29, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(132, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Filter Home Offset";
            // 
            // tbMetroFWHK
            // 
            // 
            // 
            // 
            this.tbMetroFWHK.CustomButton.Image = null;
            this.tbMetroFWHK.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroFWHK.CustomButton.Name = "";
            this.tbMetroFWHK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroFWHK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroFWHK.CustomButton.TabIndex = 1;
            this.tbMetroFWHK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroFWHK.CustomButton.UseSelectable = true;
            this.tbMetroFWHK.CustomButton.Visible = false;
            this.tbMetroFWHK.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroFWHK.Lines = new string[0];
            this.tbMetroFWHK.Location = new System.Drawing.Point(170, 73);
            this.tbMetroFWHK.MaxLength = 32767;
            this.tbMetroFWHK.Name = "tbMetroFWHK";
            this.tbMetroFWHK.PasswordChar = '\0';
            this.tbMetroFWHK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroFWHK.SelectedText = "";
            this.tbMetroFWHK.SelectionLength = 0;
            this.tbMetroFWHK.SelectionStart = 0;
            this.tbMetroFWHK.ShortcutsEnabled = true;
            this.tbMetroFWHK.Size = new System.Drawing.Size(87, 23);
            this.tbMetroFWHK.TabIndex = 25;
            this.tbMetroFWHK.UseSelectable = true;
            this.tbMetroFWHK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroFWHK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroTapeHC
            // 
            // 
            // 
            // 
            this.tbMetroTapeHC.CustomButton.Image = null;
            this.tbMetroTapeHC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroTapeHC.CustomButton.Name = "";
            this.tbMetroTapeHC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroTapeHC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroTapeHC.CustomButton.TabIndex = 1;
            this.tbMetroTapeHC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroTapeHC.CustomButton.UseSelectable = true;
            this.tbMetroTapeHC.CustomButton.Visible = false;
            this.tbMetroTapeHC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroTapeHC.Lines = new string[0];
            this.tbMetroTapeHC.Location = new System.Drawing.Point(170, 248);
            this.tbMetroTapeHC.MaxLength = 32767;
            this.tbMetroTapeHC.Name = "tbMetroTapeHC";
            this.tbMetroTapeHC.PasswordChar = '\0';
            this.tbMetroTapeHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroTapeHC.SelectedText = "";
            this.tbMetroTapeHC.SelectionLength = 0;
            this.tbMetroTapeHC.SelectionStart = 0;
            this.tbMetroTapeHC.ShortcutsEnabled = true;
            this.tbMetroTapeHC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroTapeHC.TabIndex = 24;
            this.tbMetroTapeHC.UseSelectable = true;
            this.tbMetroTapeHC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroTapeHC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroTapeMC
            // 
            // 
            // 
            // 
            this.tbMetroTapeMC.CustomButton.Image = null;
            this.tbMetroTapeMC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroTapeMC.CustomButton.Name = "";
            this.tbMetroTapeMC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroTapeMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroTapeMC.CustomButton.TabIndex = 1;
            this.tbMetroTapeMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroTapeMC.CustomButton.UseSelectable = true;
            this.tbMetroTapeMC.CustomButton.Visible = false;
            this.tbMetroTapeMC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroTapeMC.Lines = new string[0];
            this.tbMetroTapeMC.Location = new System.Drawing.Point(170, 218);
            this.tbMetroTapeMC.MaxLength = 32767;
            this.tbMetroTapeMC.Name = "tbMetroTapeMC";
            this.tbMetroTapeMC.PasswordChar = '\0';
            this.tbMetroTapeMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroTapeMC.SelectedText = "";
            this.tbMetroTapeMC.SelectionLength = 0;
            this.tbMetroTapeMC.SelectionStart = 0;
            this.tbMetroTapeMC.ShortcutsEnabled = true;
            this.tbMetroTapeMC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroTapeMC.TabIndex = 23;
            this.tbMetroTapeMC.UseSelectable = true;
            this.tbMetroTapeMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroTapeMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel66
            // 
            this.metroLabel66.AutoSize = true;
            this.metroLabel66.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel66.Location = new System.Drawing.Point(79, 250);
            this.metroLabel66.Name = "metroLabel66";
            this.metroLabel66.Size = new System.Drawing.Size(81, 19);
            this.metroLabel66.TabIndex = 22;
            this.metroLabel66.Text = "Tape HC %";
            // 
            // tbMetroNozzleHC
            // 
            // 
            // 
            // 
            this.tbMetroNozzleHC.CustomButton.Image = null;
            this.tbMetroNozzleHC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroNozzleHC.CustomButton.Name = "";
            this.tbMetroNozzleHC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroNozzleHC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroNozzleHC.CustomButton.TabIndex = 1;
            this.tbMetroNozzleHC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroNozzleHC.CustomButton.UseSelectable = true;
            this.tbMetroNozzleHC.CustomButton.Visible = false;
            this.tbMetroNozzleHC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroNozzleHC.Lines = new string[0];
            this.tbMetroNozzleHC.Location = new System.Drawing.Point(170, 189);
            this.tbMetroNozzleHC.MaxLength = 32767;
            this.tbMetroNozzleHC.Name = "tbMetroNozzleHC";
            this.tbMetroNozzleHC.PasswordChar = '\0';
            this.tbMetroNozzleHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroNozzleHC.SelectedText = "";
            this.tbMetroNozzleHC.SelectionLength = 0;
            this.tbMetroNozzleHC.SelectionStart = 0;
            this.tbMetroNozzleHC.ShortcutsEnabled = true;
            this.tbMetroNozzleHC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroNozzleHC.TabIndex = 21;
            this.tbMetroNozzleHC.UseSelectable = true;
            this.tbMetroNozzleHC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroNozzleHC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel54.Location = new System.Drawing.Point(67, 192);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(95, 19);
            this.metroLabel54.TabIndex = 20;
            this.metroLabel54.Text = "Nozzle HC %";
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel53.Location = new System.Drawing.Point(78, 221);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(83, 19);
            this.metroLabel53.TabIndex = 19;
            this.metroLabel53.Text = "Tape MC %";
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel52.Location = new System.Drawing.Point(81, 15);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(85, 19);
            this.metroLabel52.TabIndex = 18;
            this.metroLabel52.Text = "Filter MC %";
            // 
            // tbMetroNozzleMC
            // 
            // 
            // 
            // 
            this.tbMetroNozzleMC.CustomButton.Image = null;
            this.tbMetroNozzleMC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroNozzleMC.CustomButton.Name = "";
            this.tbMetroNozzleMC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroNozzleMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroNozzleMC.CustomButton.TabIndex = 1;
            this.tbMetroNozzleMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroNozzleMC.CustomButton.UseSelectable = true;
            this.tbMetroNozzleMC.CustomButton.Visible = false;
            this.tbMetroNozzleMC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroNozzleMC.Lines = new string[0];
            this.tbMetroNozzleMC.Location = new System.Drawing.Point(170, 160);
            this.tbMetroNozzleMC.MaxLength = 32767;
            this.tbMetroNozzleMC.Name = "tbMetroNozzleMC";
            this.tbMetroNozzleMC.PasswordChar = '\0';
            this.tbMetroNozzleMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroNozzleMC.SelectedText = "";
            this.tbMetroNozzleMC.SelectionLength = 0;
            this.tbMetroNozzleMC.SelectionStart = 0;
            this.tbMetroNozzleMC.ShortcutsEnabled = true;
            this.tbMetroNozzleMC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroNozzleMC.TabIndex = 17;
            this.tbMetroNozzleMC.UseSelectable = true;
            this.tbMetroNozzleMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroNozzleMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroDHC
            // 
            // 
            // 
            // 
            this.tbMetroDHC.CustomButton.Image = null;
            this.tbMetroDHC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroDHC.CustomButton.Name = "";
            this.tbMetroDHC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroDHC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroDHC.CustomButton.TabIndex = 1;
            this.tbMetroDHC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroDHC.CustomButton.UseSelectable = true;
            this.tbMetroDHC.CustomButton.Visible = false;
            this.tbMetroDHC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroDHC.Lines = new string[0];
            this.tbMetroDHC.Location = new System.Drawing.Point(170, 131);
            this.tbMetroDHC.MaxLength = 32767;
            this.tbMetroDHC.Name = "tbMetroDHC";
            this.tbMetroDHC.PasswordChar = '\0';
            this.tbMetroDHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroDHC.SelectedText = "";
            this.tbMetroDHC.SelectionLength = 0;
            this.tbMetroDHC.SelectionStart = 0;
            this.tbMetroDHC.ShortcutsEnabled = true;
            this.tbMetroDHC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroDHC.TabIndex = 16;
            this.tbMetroDHC.UseSelectable = true;
            this.tbMetroDHC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroDHC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroDMC
            // 
            // 
            // 
            // 
            this.tbMetroDMC.CustomButton.Image = null;
            this.tbMetroDMC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroDMC.CustomButton.Name = "";
            this.tbMetroDMC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroDMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroDMC.CustomButton.TabIndex = 1;
            this.tbMetroDMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroDMC.CustomButton.UseSelectable = true;
            this.tbMetroDMC.CustomButton.Visible = false;
            this.tbMetroDMC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroDMC.Lines = new string[0];
            this.tbMetroDMC.Location = new System.Drawing.Point(170, 102);
            this.tbMetroDMC.MaxLength = 32767;
            this.tbMetroDMC.Name = "tbMetroDMC";
            this.tbMetroDMC.PasswordChar = '\0';
            this.tbMetroDMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroDMC.SelectedText = "";
            this.tbMetroDMC.SelectionLength = 0;
            this.tbMetroDMC.SelectionStart = 0;
            this.tbMetroDMC.ShortcutsEnabled = true;
            this.tbMetroDMC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroDMC.TabIndex = 15;
            this.tbMetroDMC.UseSelectable = true;
            this.tbMetroDMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroDMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroFWHC
            // 
            // 
            // 
            // 
            this.tbMetroFWHC.CustomButton.Image = null;
            this.tbMetroFWHC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroFWHC.CustomButton.Name = "";
            this.tbMetroFWHC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroFWHC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroFWHC.CustomButton.TabIndex = 1;
            this.tbMetroFWHC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroFWHC.CustomButton.UseSelectable = true;
            this.tbMetroFWHC.CustomButton.Visible = false;
            this.tbMetroFWHC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroFWHC.Lines = new string[0];
            this.tbMetroFWHC.Location = new System.Drawing.Point(170, 42);
            this.tbMetroFWHC.MaxLength = 32767;
            this.tbMetroFWHC.Name = "tbMetroFWHC";
            this.tbMetroFWHC.PasswordChar = '\0';
            this.tbMetroFWHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroFWHC.SelectedText = "";
            this.tbMetroFWHC.SelectionLength = 0;
            this.tbMetroFWHC.SelectionStart = 0;
            this.tbMetroFWHC.ShortcutsEnabled = true;
            this.tbMetroFWHC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroFWHC.TabIndex = 14;
            this.tbMetroFWHC.UseSelectable = true;
            this.tbMetroFWHC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroFWHC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMetroFWMC
            // 
            // 
            // 
            // 
            this.tbMetroFWMC.CustomButton.Image = null;
            this.tbMetroFWMC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbMetroFWMC.CustomButton.Name = "";
            this.tbMetroFWMC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMetroFWMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMetroFWMC.CustomButton.TabIndex = 1;
            this.tbMetroFWMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMetroFWMC.CustomButton.UseSelectable = true;
            this.tbMetroFWMC.CustomButton.Visible = false;
            this.tbMetroFWMC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMetroFWMC.Lines = new string[0];
            this.tbMetroFWMC.Location = new System.Drawing.Point(170, 12);
            this.tbMetroFWMC.MaxLength = 32767;
            this.tbMetroFWMC.Name = "tbMetroFWMC";
            this.tbMetroFWMC.PasswordChar = '\0';
            this.tbMetroFWMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMetroFWMC.SelectedText = "";
            this.tbMetroFWMC.SelectionLength = 0;
            this.tbMetroFWMC.SelectionStart = 0;
            this.tbMetroFWMC.ShortcutsEnabled = true;
            this.tbMetroFWMC.Size = new System.Drawing.Size(87, 23);
            this.tbMetroFWMC.TabIndex = 13;
            this.tbMetroFWMC.UseSelectable = true;
            this.tbMetroFWMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMetroFWMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel43.Location = new System.Drawing.Point(66, 163);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(97, 19);
            this.metroLabel43.TabIndex = 11;
            this.metroLabel43.Text = "Nozzle MC %";
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel49.Location = new System.Drawing.Point(57, 133);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(107, 19);
            this.metroLabel49.TabIndex = 10;
            this.metroLabel49.Text = "Dynamic HC %";
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel50.Location = new System.Drawing.Point(55, 105);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(109, 19);
            this.metroLabel50.TabIndex = 9;
            this.metroLabel50.Text = "Dynamic MC %";
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel51.Location = new System.Drawing.Point(82, 45);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(83, 19);
            this.metroLabel51.TabIndex = 8;
            this.metroLabel51.Text = "Filter HC %";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.tbmTubeTempWarning);
            this.metroPanel1.Controls.Add(this.tbmTubeTempError);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(559, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(289, 81);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(39, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(143, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Tube Temp Error (C)";
            // 
            // tbmTubeTempWarning
            // 
            // 
            // 
            // 
            this.tbmTubeTempWarning.CustomButton.Image = null;
            this.tbmTubeTempWarning.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbmTubeTempWarning.CustomButton.Name = "";
            this.tbmTubeTempWarning.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbmTubeTempWarning.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbmTubeTempWarning.CustomButton.TabIndex = 1;
            this.tbmTubeTempWarning.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbmTubeTempWarning.CustomButton.UseSelectable = true;
            this.tbmTubeTempWarning.CustomButton.Visible = false;
            this.tbmTubeTempWarning.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbmTubeTempWarning.Lines = new string[0];
            this.tbmTubeTempWarning.Location = new System.Drawing.Point(189, 41);
            this.tbmTubeTempWarning.MaxLength = 32767;
            this.tbmTubeTempWarning.Name = "tbmTubeTempWarning";
            this.tbmTubeTempWarning.PasswordChar = '\0';
            this.tbmTubeTempWarning.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbmTubeTempWarning.SelectedText = "";
            this.tbmTubeTempWarning.SelectionLength = 0;
            this.tbmTubeTempWarning.SelectionStart = 0;
            this.tbmTubeTempWarning.ShortcutsEnabled = true;
            this.tbmTubeTempWarning.Size = new System.Drawing.Size(87, 23);
            this.tbmTubeTempWarning.TabIndex = 14;
            this.tbmTubeTempWarning.UseSelectable = true;
            this.tbmTubeTempWarning.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbmTubeTempWarning.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbmTubeTempError
            // 
            // 
            // 
            // 
            this.tbmTubeTempError.CustomButton.Image = null;
            this.tbmTubeTempError.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tbmTubeTempError.CustomButton.Name = "";
            this.tbmTubeTempError.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbmTubeTempError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbmTubeTempError.CustomButton.TabIndex = 1;
            this.tbmTubeTempError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbmTubeTempError.CustomButton.UseSelectable = true;
            this.tbmTubeTempError.CustomButton.Visible = false;
            this.tbmTubeTempError.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbmTubeTempError.Lines = new string[0];
            this.tbmTubeTempError.Location = new System.Drawing.Point(189, 12);
            this.tbmTubeTempError.MaxLength = 32767;
            this.tbmTubeTempError.Name = "tbmTubeTempError";
            this.tbmTubeTempError.PasswordChar = '\0';
            this.tbmTubeTempError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbmTubeTempError.SelectedText = "";
            this.tbmTubeTempError.SelectionLength = 0;
            this.tbmTubeTempError.SelectionStart = 0;
            this.tbmTubeTempError.ShortcutsEnabled = true;
            this.tbmTubeTempError.Size = new System.Drawing.Size(87, 23);
            this.tbmTubeTempError.TabIndex = 13;
            this.tbmTubeTempError.UseSelectable = true;
            this.tbmTubeTempError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbmTubeTempError.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(17, 44);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(165, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Tube Temp Warning (C)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.mrbTemperatureSensorTypeT60);
            this.panel2.Controls.Add(this.mrbTemperatureSensorType110S);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Location = new System.Drawing.Point(424, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 208);
            this.panel2.TabIndex = 32;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(25, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 25);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Sensor Type";
            // 
            // mrbTemperatureSensorTypeT60
            // 
            this.mrbTemperatureSensorTypeT60.AutoSize = true;
            this.mrbTemperatureSensorTypeT60.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrbTemperatureSensorTypeT60.Location = new System.Drawing.Point(30, 115);
            this.mrbTemperatureSensorTypeT60.Name = "mrbTemperatureSensorTypeT60";
            this.mrbTemperatureSensorTypeT60.Size = new System.Drawing.Size(60, 28);
            this.mrbTemperatureSensorTypeT60.TabIndex = 29;
            this.mrbTemperatureSensorTypeT60.Text = "T60";
            this.mrbTemperatureSensorTypeT60.UseVisualStyleBackColor = true;
            // 
            // mrbTemperatureSensorType110S
            // 
            this.mrbTemperatureSensorType110S.AutoSize = true;
            this.mrbTemperatureSensorType110S.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrbTemperatureSensorType110S.Location = new System.Drawing.Point(29, 76);
            this.mrbTemperatureSensorType110S.Name = "mrbTemperatureSensorType110S";
            this.mrbTemperatureSensorType110S.Size = new System.Drawing.Size(70, 28);
            this.mrbTemperatureSensorType110S.TabIndex = 28;
            this.mrbTemperatureSensorType110S.Text = "110S";
            this.mrbTemperatureSensorType110S.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Temperature ";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.mtbSampleFlowRate);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.mtbFlowWarning);
            this.metroPanel2.Controls.Add(this.mtbFlowError);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(51, 408);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(350, 110);
            this.metroPanel2.TabIndex = 33;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(99, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Flow Error (L/min)";
            // 
            // mtbFlowWarning
            // 
            // 
            // 
            // 
            this.mtbFlowWarning.CustomButton.Image = null;
            this.mtbFlowWarning.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.mtbFlowWarning.CustomButton.Name = "";
            this.mtbFlowWarning.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbFlowWarning.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbFlowWarning.CustomButton.TabIndex = 1;
            this.mtbFlowWarning.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbFlowWarning.CustomButton.UseSelectable = true;
            this.mtbFlowWarning.CustomButton.Visible = false;
            this.mtbFlowWarning.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbFlowWarning.Lines = new string[0];
            this.mtbFlowWarning.Location = new System.Drawing.Point(243, 45);
            this.mtbFlowWarning.MaxLength = 32767;
            this.mtbFlowWarning.Name = "mtbFlowWarning";
            this.mtbFlowWarning.PasswordChar = '\0';
            this.mtbFlowWarning.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbFlowWarning.SelectedText = "";
            this.mtbFlowWarning.SelectionLength = 0;
            this.mtbFlowWarning.SelectionStart = 0;
            this.mtbFlowWarning.ShortcutsEnabled = true;
            this.mtbFlowWarning.Size = new System.Drawing.Size(87, 23);
            this.mtbFlowWarning.TabIndex = 14;
            this.mtbFlowWarning.UseSelectable = true;
            this.mtbFlowWarning.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbFlowWarning.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbFlowError
            // 
            // 
            // 
            // 
            this.mtbFlowError.CustomButton.Image = null;
            this.mtbFlowError.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.mtbFlowError.CustomButton.Name = "";
            this.mtbFlowError.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbFlowError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbFlowError.CustomButton.TabIndex = 1;
            this.mtbFlowError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbFlowError.CustomButton.UseSelectable = true;
            this.mtbFlowError.CustomButton.Visible = false;
            this.mtbFlowError.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbFlowError.Lines = new string[0];
            this.mtbFlowError.Location = new System.Drawing.Point(243, 13);
            this.mtbFlowError.MaxLength = 32767;
            this.mtbFlowError.Name = "mtbFlowError";
            this.mtbFlowError.PasswordChar = '\0';
            this.mtbFlowError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbFlowError.SelectedText = "";
            this.mtbFlowError.SelectionLength = 0;
            this.mtbFlowError.SelectionStart = 0;
            this.mtbFlowError.ShortcutsEnabled = true;
            this.mtbFlowError.Size = new System.Drawing.Size(87, 23);
            this.mtbFlowError.TabIndex = 13;
            this.mtbFlowError.UseSelectable = true;
            this.mtbFlowError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbFlowError.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(75, 47);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(152, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Flow Warning (L/min)";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(46, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(180, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Sample Flow Rate (L/min)";
            // 
            // mtbSampleFlowRate
            // 
            // 
            // 
            // 
            this.mtbSampleFlowRate.CustomButton.Image = null;
            this.mtbSampleFlowRate.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.mtbSampleFlowRate.CustomButton.Name = "";
            this.mtbSampleFlowRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbSampleFlowRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbSampleFlowRate.CustomButton.TabIndex = 1;
            this.mtbSampleFlowRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbSampleFlowRate.CustomButton.UseSelectable = true;
            this.mtbSampleFlowRate.CustomButton.Visible = false;
            this.mtbSampleFlowRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbSampleFlowRate.Lines = new string[0];
            this.mtbSampleFlowRate.Location = new System.Drawing.Point(243, 76);
            this.mtbSampleFlowRate.MaxLength = 32767;
            this.mtbSampleFlowRate.Name = "mtbSampleFlowRate";
            this.mtbSampleFlowRate.PasswordChar = '\0';
            this.mtbSampleFlowRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbSampleFlowRate.SelectedText = "";
            this.mtbSampleFlowRate.SelectionLength = 0;
            this.mtbSampleFlowRate.SelectionStart = 0;
            this.mtbSampleFlowRate.ShortcutsEnabled = true;
            this.mtbSampleFlowRate.Size = new System.Drawing.Size(87, 23);
            this.mtbSampleFlowRate.TabIndex = 20;
            this.mtbSampleFlowRate.UseSelectable = true;
            this.mtbSampleFlowRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbSampleFlowRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 541);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel16);
            this.Controls.Add(this.mbOptionsConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xact Control Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel16.ResumeLayout(false);
            this.metroPanel16.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel93;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton mrbCL7;
        private System.Windows.Forms.RadioButton mrbModbus;
        private MetroFramework.Controls.MetroButton mbOptionsConfirm;
        private MetroFramework.Controls.MetroPanel metroPanel16;
        private MetroFramework.Controls.MetroTextBox tbMetroTapeHC;
        private MetroFramework.Controls.MetroTextBox tbMetroTapeMC;
        private MetroFramework.Controls.MetroLabel metroLabel66;
        private MetroFramework.Controls.MetroTextBox tbMetroNozzleHC;
        private MetroFramework.Controls.MetroLabel metroLabel54;
        private MetroFramework.Controls.MetroLabel metroLabel53;
        private MetroFramework.Controls.MetroLabel metroLabel52;
        private MetroFramework.Controls.MetroTextBox tbMetroNozzleMC;
        private MetroFramework.Controls.MetroTextBox tbMetroDHC;
        private MetroFramework.Controls.MetroTextBox tbMetroDMC;
        private MetroFramework.Controls.MetroTextBox tbMetroFWHC;
        private MetroFramework.Controls.MetroTextBox tbMetroFWMC;
        private MetroFramework.Controls.MetroLabel metroLabel43;
        private MetroFramework.Controls.MetroLabel metroLabel49;
        private MetroFramework.Controls.MetroLabel metroLabel50;
        private MetroFramework.Controls.MetroLabel metroLabel51;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbmTubeTempWarning;
        private MetroFramework.Controls.MetroTextBox tbmTubeTempError;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbMetroFWHK;
        private MetroFramework.Controls.MetroButton mbCL7Toggle;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RadioButton mrbTemperatureSensorTypeT60;
        private System.Windows.Forms.RadioButton mrbTemperatureSensorType110S;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtbFlowWarning;
        private MetroFramework.Controls.MetroTextBox mtbFlowError;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtbSampleFlowRate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}