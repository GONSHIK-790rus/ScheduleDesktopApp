using Guna.UI2.WinForms;
using System.Net.Mail;

namespace ScheduleApp {
    public partial class EntryForm : Form
    {
        private static EntryForm? _entryForm;
        public static EntryForm GetEntryForm() {
            return _entryForm ??= new EntryForm();
        }

        private EntryForm() {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e) {
            Hide();
            MainForm.AllFormsClosed();
        }

        private void Button_Enter_Click(object sender, EventArgs e) {
            if (MailIsValid(TextBox_Login.Text)) {
                if (PasswordIsInvalid(TextBox_Password.Text)) {

                }
                else
                    EmptyData(TextBox_Password);
            }
            else
                EmptyData(TextBox_Login);
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
            return !(string.IsNullOrEmpty(password)) && password.Length < 8;
        }

        private void EmptyData(Guna2TextBox textBox) {
            StylesAndAnimations.ErrorTextBoxFlashing(textBox);
        }

        private void PictureBox_MainPicture_Click(object sender, EventArgs e) {
            MessageBox.Show("ПасхалОчка\nВ очко себе тыкни блять }:(", "☑️Certified Gay");
        }
    }
}
