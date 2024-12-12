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
    }
}
