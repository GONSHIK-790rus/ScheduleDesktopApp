using Guna.UI2.WinForms;
using ScheduleApp.Forms;

namespace ScheduleApp {
    public partial class MainForm : Form {
        public static void AllFormsClosed() {
            _mainForm?.Show();
        }

        private static MainForm? _mainForm;
        public static MainForm GetMainForm() {
            return _mainForm ??= new MainForm();
        }

        private MainForm() {
            InitializeComponent();
            FillFormsList();
        }

        private List<Form> _formsList = [];
        private void FillFormsList() {
            _formsList.Add( EntryForm.GetEntryForm() );
            _formsList.Add( RegisterForm.GetRegisterForm() );
        }

        private void OpenNewWindow(string tag) {
            for (int i = 0; i < _formsList.Count; i++) {
                if (tag == _formsList[i].Tag.ToString()) {
                    _formsList[i].Show();
                    Hide();
                    break;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e) {
            FillFormsList();
            Guna2GradientButton? clickedButton = sender as Guna2GradientButton;
            OpenNewWindow( clickedButton.Tag.ToString() );
        }
    }
}
