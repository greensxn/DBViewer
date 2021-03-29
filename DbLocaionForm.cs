using dbviewer.Properties;
using MySql.Data.MySqlClient;
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
    public partial class DbLocaionForm : Form {

        MySqlConnection sqlConnection;
        public event Action<MySqlConnection> DbConnect;

        public DbLocaionForm() => InitializeComponent();

        private async void button1_Click(object sender, EventArgs e) {
            try {
                sqlConnection = new MySqlConnection($"server=localhost;user={tbDbUser.Text};database={tbDbName.Text};password={TbDbPass.Text}");
                await sqlConnection.OpenAsync();
            }
            catch {
                lbStatus.Text = "Статус: Ошибка подключения";
                lbStatus.ForeColor = Color.Red;
                return;
            }

            DialogResult = DialogResult.OK;

            Settings.Default["user"] = tbDbUser.Text;
            Settings.Default["name"] = tbDbName.Text;
            Settings.Default["password"] = TbDbPass.Text;
            Settings.Default.Save();

            lbStatus.Text = "";
            lbStatus.ForeColor = Color.Green;
            DbConnect?.Invoke(sqlConnection);
            Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter)
                button1_Click(null, null);
        }

        private void DbLocaionForm_Load(object sender, EventArgs e) {
            tbDbUser.Text = Settings.Default["user"].ToString();
            tbDbName.Text = Settings.Default["name"].ToString();
            TbDbPass.Text = Settings.Default["password"].ToString();
        }
    }
}
