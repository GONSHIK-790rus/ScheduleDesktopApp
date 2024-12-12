namespace ScheduleApp {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PictureBox_MainPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            Panel_TopControlBox = new Panel();
            Button_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Button_Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            Label_Welcome = new Label();
            Button_Entry = new Guna.UI2.WinForms.Guna2GradientButton();
            Button_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)PictureBox_MainPicture).BeginInit();
            Panel_TopControlBox.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox_MainPicture
            // 
            PictureBox_MainPicture.CustomizableEdges = customizableEdges1;
            PictureBox_MainPicture.Dock = DockStyle.Left;
            PictureBox_MainPicture.Image = Properties.Resources.servers;
            PictureBox_MainPicture.ImageRotate = 0F;
            PictureBox_MainPicture.Location = new Point(0, 0);
            PictureBox_MainPicture.Name = "PictureBox_MainPicture";
            PictureBox_MainPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PictureBox_MainPicture.Size = new Size(804, 926);
            PictureBox_MainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_MainPicture.TabIndex = 0;
            PictureBox_MainPicture.TabStop = false;
            // 
            // Panel_TopControlBox
            // 
            Panel_TopControlBox.Controls.Add(Button_Minimize);
            Panel_TopControlBox.Controls.Add(Button_Exit);
            Panel_TopControlBox.Dock = DockStyle.Top;
            Panel_TopControlBox.Location = new Point(804, 0);
            Panel_TopControlBox.Name = "Panel_TopControlBox";
            Panel_TopControlBox.Size = new Size(691, 69);
            Panel_TopControlBox.TabIndex = 1;
            // 
            // Button_Minimize
            // 
            Button_Minimize.Animated = true;
            Button_Minimize.BorderColor = Color.Transparent;
            Button_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Button_Minimize.CustomIconSize = 40F;
            Button_Minimize.CustomizableEdges = customizableEdges3;
            Button_Minimize.Dock = DockStyle.Right;
            Button_Minimize.FillColor = Color.FromArgb(30, 30, 30);
            Button_Minimize.IconColor = Color.White;
            Button_Minimize.Location = new Point(543, 0);
            Button_Minimize.Name = "Button_Minimize";
            Button_Minimize.PressedColor = Color.Gray;
            Button_Minimize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Minimize.Size = new Size(74, 69);
            Button_Minimize.TabIndex = 1;
            // 
            // Button_Exit
            // 
            Button_Exit.Animated = true;
            Button_Exit.BorderColor = Color.Transparent;
            Button_Exit.CustomIconSize = 40F;
            Button_Exit.CustomizableEdges = customizableEdges5;
            Button_Exit.Dock = DockStyle.Right;
            Button_Exit.FillColor = Color.FromArgb(30, 30, 30);
            Button_Exit.IconColor = Color.White;
            Button_Exit.Location = new Point(617, 0);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.PressedColor = Color.Red;
            Button_Exit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_Exit.Size = new Size(74, 69);
            Button_Exit.TabIndex = 0;
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Montserrat SemiBold", 20F, FontStyle.Bold);
            Label_Welcome.ForeColor = Color.FromArgb(40, 70, 220);
            Label_Welcome.Location = new Point(962, 142);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(376, 150);
            Label_Welcome.TabIndex = 2;
            Label_Welcome.Text = "Добро\r\nпожаловать";
            Label_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button_Entry
            // 
            Button_Entry.Animated = true;
            Button_Entry.AutoRoundedCorners = true;
            Button_Entry.BorderRadius = 56;
            Button_Entry.CustomizableEdges = customizableEdges7;
            Button_Entry.DisabledState.BorderColor = Color.DarkGray;
            Button_Entry.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Entry.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Entry.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Button_Entry.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Entry.FillColor = Color.FromArgb(30, 30, 30);
            Button_Entry.FillColor2 = Color.FromArgb(5, 10, 120);
            Button_Entry.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            Button_Entry.ForeColor = Color.WhiteSmoke;
            Button_Entry.IndicateFocus = true;
            Button_Entry.Location = new Point(940, 448);
            Button_Entry.Name = "Button_Entry";
            Button_Entry.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Button_Entry.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Button_Entry.Size = new Size(420, 115);
            Button_Entry.TabIndex = 3;
            Button_Entry.Tag = "Entry";
            Button_Entry.Text = "Войти";
            Button_Entry.Click += Button_Click;
            // 
            // Button_Register
            // 
            Button_Register.Animated = true;
            Button_Register.AutoRoundedCorners = true;
            Button_Register.BorderRadius = 56;
            Button_Register.CustomizableEdges = customizableEdges9;
            Button_Register.DisabledState.BorderColor = Color.DarkGray;
            Button_Register.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Register.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Register.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Button_Register.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Register.FillColor = Color.FromArgb(30, 30, 30);
            Button_Register.FillColor2 = Color.FromArgb(5, 10, 120);
            Button_Register.Font = new Font("Montserrat SemiBold", 11F, FontStyle.Bold);
            Button_Register.ForeColor = Color.WhiteSmoke;
            Button_Register.IndicateFocus = true;
            Button_Register.Location = new Point(940, 622);
            Button_Register.Name = "Button_Register";
            Button_Register.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Button_Register.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Button_Register.Size = new Size(420, 115);
            Button_Register.TabIndex = 4;
            Button_Register.Tag = "Register";
            Button_Register.Text = "Зарегистрироваться";
            Button_Register.Click += Button_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(1495, 926);
            Controls.Add(Button_Register);
            Controls.Add(Button_Entry);
            Controls.Add(Label_Welcome);
            Controls.Add(Panel_TopControlBox);
            Controls.Add(PictureBox_MainPicture);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добро пожаловать";
            ((System.ComponentModel.ISupportInitialize)PictureBox_MainPicture).EndInit();
            Panel_TopControlBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_MainPicture;
        private Panel Panel_TopControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Exit;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Minimize;
        private Label Label_Welcome;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Entry;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Register;
    }
}
