using dbviewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbviewer {
    public partial class ChangeNameForm : Form {

        public event Action<String> ProgramNameChange;

        public ChangeNameForm() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;

            Settings.Default["program"] = tbProgramName.Text;
            Settings.Default.Save();

            ProgramNameChange?.Invoke(tbProgramName.Text);
            Close();
        }

        private void tbProgramName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter)
                button1_Click(null, null);
        }
    }
}
