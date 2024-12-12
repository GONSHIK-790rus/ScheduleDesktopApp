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
            Button_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Button_Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            Panel_TopControlBox = new Panel();
            Panel_TopControlBox.SuspendLayout();
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
            Button_Minimize.Location = new Point(970, 0);
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
            Button_Exit.Location = new Point(1044, 0);
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
            Panel_TopControlBox.Location = new Point(0, 0);
            Panel_TopControlBox.Name = "Panel_TopControlBox";
            Panel_TopControlBox.Size = new Size(1118, 69);
            Panel_TopControlBox.TabIndex = 2;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(1118, 850);
            Controls.Add(Panel_TopControlBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntryForm";
            Tag = "Entry";
            Text = "Вход";
            Panel_TopControlBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox Button_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Exit;
        private Panel Panel_TopControlBox;
    }
}