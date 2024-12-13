namespace ScheduleApp
{
    partial class EntryForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            Button_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Button_Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            Panel_TopControlBox = new Panel();
            PictureBox_MainPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            Label_WelcomeBack = new Label();
            TextBox_Login = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            Button_Enter = new Guna.UI2.WinForms.Guna2GradientButton();
            Panel_TopControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_MainPicture).BeginInit();
            SuspendLayout();
            // 
            // Button_Minimize
            // 
            Button_Minimize.Animated = true;
            Button_Minimize.BorderColor = Color.Transparent;
            Button_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Button_Minimize.CustomIconSize = 40F;
            Button_Minimize.CustomizableEdges = customizableEdges1;
            Button_Minimize.Dock = DockStyle.Right;
            Button_Minimize.FillColor = Color.FromArgb(30, 30, 30);
            Button_Minimize.IconColor = Color.White;
            Button_Minimize.Location = new Point(577, 0);
            Button_Minimize.Name = "Button_Minimize";
            Button_Minimize.PressedColor = Color.Gray;
            Button_Minimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Minimize.Size = new Size(74, 69);
            Button_Minimize.TabIndex = 1;
            // 
            // Button_Exit
            // 
            Button_Exit.Animated = true;
            Button_Exit.BorderColor = Color.Transparent;
            Button_Exit.CustomClick = true;
            Button_Exit.CustomIconSize = 40F;
            Button_Exit.CustomizableEdges = customizableEdges3;
            Button_Exit.Dock = DockStyle.Right;
            Button_Exit.FillColor = Color.FromArgb(30, 30, 30);
            Button_Exit.IconColor = Color.White;
            Button_Exit.Location = new Point(651, 0);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.PressedColor = Color.Red;
            Button_Exit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Exit.Size = new Size(74, 69);
            Button_Exit.TabIndex = 0;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Panel_TopControlBox
            // 
            Panel_TopControlBox.Controls.Add(Button_Minimize);
            Panel_TopControlBox.Controls.Add(Button_Exit);
            Panel_TopControlBox.Dock = DockStyle.Top;
            Panel_TopControlBox.Location = new Point(804, 0);
            Panel_TopControlBox.Name = "Panel_TopControlBox";
            Panel_TopControlBox.Size = new Size(725, 69);
            Panel_TopControlBox.TabIndex = 2;
            // 
            // PictureBox_MainPicture
            // 
            PictureBox_MainPicture.CustomizableEdges = customizableEdges5;
            PictureBox_MainPicture.Dock = DockStyle.Left;
            PictureBox_MainPicture.Image = Properties.Resources.servers;
            PictureBox_MainPicture.ImageRotate = 0F;
            PictureBox_MainPicture.Location = new Point(0, 0);
            PictureBox_MainPicture.Name = "PictureBox_MainPicture";
            PictureBox_MainPicture.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PictureBox_MainPicture.Size = new Size(804, 895);
            PictureBox_MainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_MainPicture.TabIndex = 3;
            PictureBox_MainPicture.TabStop = false;
            // 
            // Label_WelcomeBack
            // 
            Label_WelcomeBack.AutoSize = true;
            Label_WelcomeBack.Font = new Font("Montserrat SemiBold", 20F, FontStyle.Bold);
            Label_WelcomeBack.ForeColor = Color.FromArgb(40, 70, 220);
            Label_WelcomeBack.Location = new Point(902, 118);
            Label_WelcomeBack.Name = "Label_WelcomeBack";
            Label_WelcomeBack.Size = new Size(525, 75);
            Label_WelcomeBack.TabIndex = 4;
            Label_WelcomeBack.Text = "С возвращением";
            Label_WelcomeBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox_Login
            // 
            TextBox_Login.Animated = true;
            TextBox_Login.BackColor = Color.Transparent;
            TextBox_Login.BorderColor = Color.FromArgb(40, 70, 220);
            TextBox_Login.BorderRadius = 15;
            TextBox_Login.CustomizableEdges = customizableEdges7;
            TextBox_Login.DefaultText = "";
            TextBox_Login.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_Login.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_Login.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Login.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Login.FillColor = Color.FromArgb(30, 30, 30);
            TextBox_Login.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Login.Font = new Font("Montserrat SemiBold", 11F);
            TextBox_Login.ForeColor = Color.LightGray;
            TextBox_Login.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Login.IconLeft = Properties.Resources.user1;
            TextBox_Login.IconLeftOffset = new Point(15, 0);
            TextBox_Login.IconLeftSize = new Size(49, 40);
            TextBox_Login.Location = new Point(902, 329);
            TextBox_Login.Margin = new Padding(8);
            TextBox_Login.MaxLength = 30;
            TextBox_Login.Name = "TextBox_Login";
            TextBox_Login.PasswordChar = '\0';
            TextBox_Login.PlaceholderForeColor = Color.FromArgb(40, 70, 220);
            TextBox_Login.PlaceholderText = "Логин";
            TextBox_Login.SelectedText = "";
            TextBox_Login.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBox_Login.Size = new Size(525, 90);
            TextBox_Login.TabIndex = 5;
            // 
            // TextBox_Password
            // 
            TextBox_Password.Animated = true;
            TextBox_Password.BackColor = Color.Transparent;
            TextBox_Password.BorderColor = Color.FromArgb(40, 70, 220);
            TextBox_Password.BorderRadius = 15;
            TextBox_Password.CustomizableEdges = customizableEdges9;
            TextBox_Password.DefaultText = "";
            TextBox_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Password.FillColor = Color.FromArgb(30, 30, 30);
            TextBox_Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Password.Font = new Font("Montserrat SemiBold", 11F);
            TextBox_Password.ForeColor = Color.LightGray;
            TextBox_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Password.IconLeft = Properties.Resources._lock;
            TextBox_Password.IconLeftOffset = new Point(15, 0);
            TextBox_Password.IconLeftSize = new Size(40, 40);
            TextBox_Password.Location = new Point(902, 466);
            TextBox_Password.Margin = new Padding(8);
            TextBox_Password.MaxLength = 30;
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '\0';
            TextBox_Password.PlaceholderForeColor = Color.FromArgb(40, 70, 220);
            TextBox_Password.PlaceholderText = "Пароль";
            TextBox_Password.SelectedText = "";
            TextBox_Password.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TextBox_Password.Size = new Size(525, 90);
            TextBox_Password.TabIndex = 6;
            // 
            // Button_Enter
            // 
            Button_Enter.Animated = true;
            Button_Enter.AutoRoundedCorners = true;
            Button_Enter.BorderRadius = 44;
            Button_Enter.CustomizableEdges = customizableEdges11;
            Button_Enter.DisabledState.BorderColor = Color.DarkGray;
            Button_Enter.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Enter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Enter.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Button_Enter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Enter.FillColor = Color.FromArgb(30, 30, 30);
            Button_Enter.FillColor2 = Color.FromArgb(5, 10, 120);
            Button_Enter.Font = new Font("Montserrat SemiBold", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Enter.ForeColor = Color.White;
            Button_Enter.Location = new Point(982, 653);
            Button_Enter.Name = "Button_Enter";
            Button_Enter.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Button_Enter.Size = new Size(360, 90);
            Button_Enter.TabIndex = 7;
            Button_Enter.Text = "Войти";
            Button_Enter.Click += Button_Enter_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(1529, 895);
            Controls.Add(Button_Enter);
            Controls.Add(TextBox_Password);
            Controls.Add(TextBox_Login);
            Controls.Add(Label_WelcomeBack);
            Controls.Add(Panel_TopControlBox);
            Controls.Add(PictureBox_MainPicture);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Entry";
            Text = "Вход";
            Panel_TopControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_MainPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox Button_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Exit;
        private Panel Panel_TopControlBox;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox_MainPicture;
        private Label Label_WelcomeBack;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Login;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Enter;
    }
}