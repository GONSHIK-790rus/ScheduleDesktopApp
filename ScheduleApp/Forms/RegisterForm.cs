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

        private void Button_Exit_Click(object sender, EventArgs e) {
            Hide();
            MainForm.AllFormsClosed();
        }

        private void Button_Next_Click(object sender, EventArgs e) {
            SetPanelVisibility();
        }

        private void Button_Back_Click(object sender, EventArgs e) {
            SetPanelVisibility();
        }

        private void SetPanelVisibility() {
            Panel_FirstStepOfReg.Visible = !Panel_FirstStepOfReg.Visible;
            Panel_SecondStepOfReg.Visible = !Panel_SecondStepOfReg.Visible;
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

        private bool PasswordIsInvalid(string password) {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            Regex passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)$");
            return passwordRegex.IsMatch(password);
        }
    }
}
