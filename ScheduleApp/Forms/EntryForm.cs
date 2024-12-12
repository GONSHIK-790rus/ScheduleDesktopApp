namespace ScheduleApp {
    public partial class EntryForm : Form {
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

        }
    }
}
