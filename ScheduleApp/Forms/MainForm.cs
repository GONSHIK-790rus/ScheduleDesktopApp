namespace ScheduleApp {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private readonly EntryForm entryForm = EntryForm.GetEntryForm();
        private void OpenNewWindow(string tag) {
            if (tag == entryForm.Tag.ToString()) { 
                entryForm.Show();
                Close();
                return;
            }


        }

        private void Button_Click(object sender, EventArgs e) {
            Button? clickedButton = sender as Button;
            OpenNewWindow( clickedButton.Tag.ToString() );
        }
    }
}
