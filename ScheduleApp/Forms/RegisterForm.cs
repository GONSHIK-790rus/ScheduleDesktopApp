using Guna.UI2.WinForms;
using ScheduleApp.User;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ScheduleApp.Forms {
    public partial class RegisterForm : Form {
        private static RegisterForm? _registerForm;
        public static RegisterForm GetRegisterForm() {
            return _registerForm ??= new RegisterForm();
        }

        private RegisterForm() {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e) {
            CreateAccount();
        }

        private void CreateAccount() {
            if (CheckForCorrectData(Panel_FirstStepOfReg, Panel_SecondStepOfReg))
            {
                
            }
            
        }

        private bool CheckForCorrectData(params Panel[] panels) {
            foreach (Panel panel in panels) {
                foreach (Guna2TextBox textBox in panel.Controls.OfType<Guna2TextBox>()) {
                    if (textBox.Name.ToString() == "TextBox_Patronymic" && textBox.BorderColor != Color.Red)
                        continue;

                    if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.BorderColor == Color.Red)
                        return false;
                }
            }

            return true;
        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            Hide();
            MainForm.AllFormsClosed();
        }

        private void Button_NextOrBack_Click(object sender, EventArgs e) {
            SetPanelVisibility();
        }

        private void SetPanelVisibility() {
            Panel_FirstStepOfReg.Visible = !Panel_FirstStepOfReg.Visible;
            Panel_SecondStepOfReg.Visible = !Panel_SecondStepOfReg.Visible;
        }

        private void TextBox_Login_Leave(object sender, EventArgs e) {
            if (!MailIsValid(TextBox_Login.Text)) {
                StylesAndAnimations.ErrorTextBox(TextBox_Login);
                Label_IncorrectLogin.Visible = true;
            }
        }

        private const string _PASSWORD_TAG = "password";
        private void TextBox_Enter(object sender, EventArgs e) {
            Guna2TextBox textBox = sender as Guna2TextBox;
            StylesAndAnimations.SetCommonStyleForTextBox(textBox);
            HideLabels(textBox);
        }

        private void TextBox_PersonData_Leave(object sender, EventArgs e) {
            Guna2TextBox textBox = sender as Guna2TextBox;

            if (textBox.Text.Any(char.IsDigit) || textBox.Text.Any(char.IsPunctuation) || string.IsNullOrEmpty(textBox.Text)) {
                StylesAndAnimations.ErrorTextBox(textBox);
                return;
            }

            textBox.Text = GetStringWithCorrectSymbolsCase(textBox);
        }

        private void TextBox_Patronymic_Leave(object sender, EventArgs e) {
            Guna2TextBox textBox = sender as Guna2TextBox;

            if (string.IsNullOrEmpty(textBox.Text))
                return;

            if (textBox.Text.Any(char.IsDigit))
                StylesAndAnimations.ErrorTextBox(textBox);

            textBox.Text = GetStringWithCorrectSymbolsCase(textBox);
        }

        private void HideLabels(Guna2TextBox textBox) {
            if (textBox.Tag == null)
                return;

            if (textBox.Tag.ToString() == _PASSWORD_TAG)
                ShowToolTip();

            switch (textBox.Tag.ToString()) {
                case "login":
                    Label_IncorrectLogin.Visible = false;
                    break;

                case "password":
                    Label_IncorrectPassword.Visible = false;
                    break;

                case "repeatPassword":
                    Label_PswrdDoesntMatch.Visible = false;
                    break;

            }
        }

        private string GetStringWithCorrectSymbolsCase(Guna2TextBox textBox) {
            string buf = textBox.Text.Trim().Substring(1).ToLower();
            return textBox.Text[0].ToString().ToUpper() + buf;
        }

        private bool MailIsValid(string emailAddress) {
            if (string.IsNullOrEmpty(emailAddress))
                return false;

            try {
                var mail = new MailAddress(emailAddress);
                return true;
            }
            catch {
                return false;
            }
        }

        private void TextBox_Password_Leave(object sender, EventArgs e) {
            ToolTipForPassword?.Hide(this);
            Guna2TextBox textBox = sender as Guna2TextBox;

            if (!PasswordIsInvalid(textBox.Text)) {
                StylesAndAnimations.ErrorTextBox(textBox);
                Label_IncorrectPassword.Visible = true;
            }

            if (!string.IsNullOrEmpty(TextBox_RepeatPswrd.Text))
                TextBox_RepeatPswrd_Leave(TextBox_RepeatPswrd, e);
        }

        private bool PasswordIsInvalid(string password) {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            return (new Regex(@"[A-Z]")).IsMatch(password)
                && (new Regex(@"[a-z]")).IsMatch(password)
                && (new Regex(@"\d")).IsMatch(password);
        }

        private void TextBox_RepeatPswrd_Leave(object sender, EventArgs e) {
            if (TextBox_RepeatPswrd.Text != TextBox_Password.Text) {
                StylesAndAnimations.ErrorTextBox(TextBox_RepeatPswrd);
                Label_PswrdDoesntMatch.Visible = true;
            }
            else {
                StylesAndAnimations.SetCommonStyleForTextBox(TextBox_RepeatPswrd);
                Label_PswrdDoesntMatch.Visible = false;
            }
        }

        private void ShowToolTip() {
            ToolTipForPassword.Show("Пароль должен содержать не менее 8 символов," +
                "<br>включая верхний и нижний регистр, а также цифры.",
                TextBox_Password,
                -40,
                -85,
                5_000);
        }
    }
}
