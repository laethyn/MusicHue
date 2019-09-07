namespace MusicBeePlugin.Forms
{
    partial class HueSettings_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.RegistrationGroup = new System.Windows.Forms.GroupBox();
            this.GetKey_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_ShowRegistration = new System.Windows.Forms.CheckBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Brightness_TB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ColorPalette_Radio = new System.Windows.Forms.RadioButton();
            this.AverageColor_Radio = new System.Windows.Forms.RadioButton();
            this.AddedLights_ListBox = new System.Windows.Forms.ListBox();
            this.HueLights_ListBox = new System.Windows.Forms.ListBox();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SaveSettings_Button = new System.Windows.Forms.Button();
            this.RemoveLight_Button = new System.Windows.Forms.Button();
            this.AddLight_Button = new System.Windows.Forms.Button();
            this.GetLights_Button = new System.Windows.Forms.Button();
            this.Activity_LBL = new System.Windows.Forms.Label();
            this.RegistrationGroup.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationGroup
            // 
            this.RegistrationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationGroup.Controls.Add(this.GetKey_Button);
            this.RegistrationGroup.Controls.Add(this.label4);
            this.RegistrationGroup.Controls.Add(this.label3);
            this.RegistrationGroup.Controls.Add(this.label2);
            this.RegistrationGroup.Controls.Add(this.label1);
            this.RegistrationGroup.Location = new System.Drawing.Point(12, 36);
            this.RegistrationGroup.Name = "RegistrationGroup";
            this.RegistrationGroup.Size = new System.Drawing.Size(571, 135);
            this.RegistrationGroup.TabIndex = 0;
            this.RegistrationGroup.TabStop = false;
            this.RegistrationGroup.Text = "Registration";
            // 
            // GetKey_Button
            // 
            this.GetKey_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetKey_Button.AutoSize = true;
            this.GetKey_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetKey_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetKey_Button.Location = new System.Drawing.Point(257, 97);
            this.GetKey_Button.Name = "GetKey_Button";
            this.GetKey_Button.Size = new System.Drawing.Size(62, 23);
            this.GetKey_Button.TabIndex = 4;
            this.GetKey_Button.Text = "Get Key";
            this.GetKey_Button.UseVisualStyleBackColor = true;
            this.GetKey_Button.Click += new System.EventHandler(this.GetKey_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Step 3: If you see your key show up, the plugin is now registered.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step 2: You have 30s to press the \"Get Key\" Button.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 1: Press the button on your Philips Hue Bridge.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "READ ALL STEPS BEFORE ATTEMPTING TO REGISTER THE PLUGIN";
            // 
            // chk_ShowRegistration
            // 
            this.chk_ShowRegistration.AutoSize = true;
            this.chk_ShowRegistration.Location = new System.Drawing.Point(13, 13);
            this.chk_ShowRegistration.Name = "chk_ShowRegistration";
            this.chk_ShowRegistration.Size = new System.Drawing.Size(112, 17);
            this.chk_ShowRegistration.TabIndex = 1;
            this.chk_ShowRegistration.Text = "Show Registration";
            this.chk_ShowRegistration.UseVisualStyleBackColor = true;
            this.chk_ShowRegistration.CheckedChanged += new System.EventHandler(this.Chk_ShowRegistration_CheckedChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.Activity_LBL);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.AddedLights_ListBox);
            this.MainPanel.Controls.Add(this.HueLights_ListBox);
            this.MainPanel.Controls.Add(this.Refresh_Button);
            this.MainPanel.Controls.Add(this.Delete_Button);
            this.MainPanel.Controls.Add(this.SaveSettings_Button);
            this.MainPanel.Controls.Add(this.RemoveLight_Button);
            this.MainPanel.Controls.Add(this.AddLight_Button);
            this.MainPanel.Controls.Add(this.GetLights_Button);
            this.MainPanel.Enabled = false;
            this.MainPanel.Location = new System.Drawing.Point(13, 178);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(570, 233);
            this.MainPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Brightness_TB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ColorPalette_Radio);
            this.groupBox1.Controls.Add(this.AverageColor_Radio);
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light Options";
            // 
            // Brightness_TB
            // 
            this.Brightness_TB.Location = new System.Drawing.Point(9, 87);
            this.Brightness_TB.Name = "Brightness_TB";
            this.Brightness_TB.Size = new System.Drawing.Size(178, 45);
            this.Brightness_TB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Brightness";
            // 
            // ColorPalette_Radio
            // 
            this.ColorPalette_Radio.AutoSize = true;
            this.ColorPalette_Radio.Location = new System.Drawing.Point(6, 42);
            this.ColorPalette_Radio.Name = "ColorPalette_Radio";
            this.ColorPalette_Radio.Size = new System.Drawing.Size(85, 17);
            this.ColorPalette_Radio.TabIndex = 1;
            this.ColorPalette_Radio.TabStop = true;
            this.ColorPalette_Radio.Text = "Color Palette";
            this.ColorPalette_Radio.UseVisualStyleBackColor = true;
            // 
            // AverageColor_Radio
            // 
            this.AverageColor_Radio.AutoSize = true;
            this.AverageColor_Radio.Location = new System.Drawing.Point(6, 19);
            this.AverageColor_Radio.Name = "AverageColor_Radio";
            this.AverageColor_Radio.Size = new System.Drawing.Size(92, 17);
            this.AverageColor_Radio.TabIndex = 0;
            this.AverageColor_Radio.TabStop = true;
            this.AverageColor_Radio.Text = "Average Color";
            this.AverageColor_Radio.UseVisualStyleBackColor = true;
            // 
            // AddedLights_ListBox
            // 
            this.AddedLights_ListBox.FormattingEnabled = true;
            this.AddedLights_ListBox.Location = new System.Drawing.Point(331, 3);
            this.AddedLights_ListBox.Name = "AddedLights_ListBox";
            this.AddedLights_ListBox.Size = new System.Drawing.Size(160, 82);
            this.AddedLights_ListBox.TabIndex = 7;
            // 
            // HueLights_ListBox
            // 
            this.HueLights_ListBox.FormattingEnabled = true;
            this.HueLights_ListBox.Location = new System.Drawing.Point(79, 3);
            this.HueLights_ListBox.Name = "HueLights_ListBox";
            this.HueLights_ListBox.Size = new System.Drawing.Size(160, 82);
            this.HueLights_ListBox.TabIndex = 6;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_Button.Location = new System.Drawing.Point(497, 63);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(70, 24);
            this.Refresh_Button.TabIndex = 5;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Button.Location = new System.Drawing.Point(497, 33);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(70, 24);
            this.Delete_Button.TabIndex = 4;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // SaveSettings_Button
            // 
            this.SaveSettings_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSettings_Button.Location = new System.Drawing.Point(497, 3);
            this.SaveSettings_Button.Name = "SaveSettings_Button";
            this.SaveSettings_Button.Size = new System.Drawing.Size(70, 24);
            this.SaveSettings_Button.TabIndex = 3;
            this.SaveSettings_Button.Text = "Save";
            this.SaveSettings_Button.UseVisualStyleBackColor = true;
            this.SaveSettings_Button.Click += new System.EventHandler(this.SaveSettings_Button_Click);
            // 
            // RemoveLight_Button
            // 
            this.RemoveLight_Button.Location = new System.Drawing.Point(245, 34);
            this.RemoveLight_Button.Name = "RemoveLight_Button";
            this.RemoveLight_Button.Size = new System.Drawing.Size(80, 23);
            this.RemoveLight_Button.TabIndex = 2;
            this.RemoveLight_Button.Text = "<< Remove";
            this.RemoveLight_Button.UseVisualStyleBackColor = true;
            this.RemoveLight_Button.Click += new System.EventHandler(this.RemoveLight_Button_Click);
            // 
            // AddLight_Button
            // 
            this.AddLight_Button.Location = new System.Drawing.Point(245, 4);
            this.AddLight_Button.Name = "AddLight_Button";
            this.AddLight_Button.Size = new System.Drawing.Size(80, 24);
            this.AddLight_Button.TabIndex = 1;
            this.AddLight_Button.Text = "Add >>";
            this.AddLight_Button.UseVisualStyleBackColor = true;
            this.AddLight_Button.Click += new System.EventHandler(this.AddLight_Button_Click);
            // 
            // GetLights_Button
            // 
            this.GetLights_Button.Location = new System.Drawing.Point(3, 3);
            this.GetLights_Button.Name = "GetLights_Button";
            this.GetLights_Button.Size = new System.Drawing.Size(70, 24);
            this.GetLights_Button.TabIndex = 0;
            this.GetLights_Button.Text = "Get Lights";
            this.GetLights_Button.UseVisualStyleBackColor = true;
            this.GetLights_Button.Click += new System.EventHandler(this.GetLights_Button_Click);
            // 
            // Activity_LBL
            // 
            this.Activity_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_LBL.ForeColor = System.Drawing.Color.Green;
            this.Activity_LBL.Location = new System.Drawing.Point(245, 207);
            this.Activity_LBL.Name = "Activity_LBL";
            this.Activity_LBL.Size = new System.Drawing.Size(322, 23);
            this.Activity_LBL.TabIndex = 9;
            this.Activity_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HueSettings_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(595, 420);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.chk_ShowRegistration);
            this.Controls.Add(this.RegistrationGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HueSettings_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MusicHue Settings";
            this.Load += new System.EventHandler(this.HueSettings_FRM_Load);
            this.RegistrationGroup.ResumeLayout(false);
            this.RegistrationGroup.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RegistrationGroup;
        private System.Windows.Forms.CheckBox chk_ShowRegistration;
        private System.Windows.Forms.Button GetKey_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar Brightness_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ColorPalette_Radio;
        private System.Windows.Forms.RadioButton AverageColor_Radio;
        private System.Windows.Forms.ListBox AddedLights_ListBox;
        private System.Windows.Forms.ListBox HueLights_ListBox;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button SaveSettings_Button;
        private System.Windows.Forms.Button RemoveLight_Button;
        private System.Windows.Forms.Button AddLight_Button;
        private System.Windows.Forms.Button GetLights_Button;
        private System.Windows.Forms.Label Activity_LBL;
    }
}