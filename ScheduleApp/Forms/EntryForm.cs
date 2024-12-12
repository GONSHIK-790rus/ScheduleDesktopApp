using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp {
    public partial class EntryForm : Form {
        private static EntryForm form = new();
        public static EntryForm GetEntryForm() {
            if (form == null)
                form = new EntryForm();
            return form;
        }

        private EntryForm() {
            InitializeComponent();
        }
    }
}
