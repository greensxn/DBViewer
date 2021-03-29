using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbviewer.Properties;
using MySql.Data.MySqlClient;


namespace dbviewer {
    public partial class
        Form1 : Form {

        MySqlConnection sqlConnection;
        OleDbConnection asd;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => Text = Settings.Default.program;

        private void FillSelect(String table, DataGridView view) {
            MySqlCommand comm = new MySqlCommand($"select * from {table}", sqlConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            adapter.Fill(dt);
            view.DataSource = dt;

        }

        private void UpdateSelect() {
            FillSelect("capital", dataCapital);
            FillSelect("continent", dataContinent);
            FillSelect("country", dataCountry);
            FillSelect("currency", dataCurrency);
            FillSelect("language", dataLang);
        }

        //UPDATE COMMAND
        private async void UPDATE_country_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbIdUpdCountry.Text) || String.IsNullOrWhiteSpace(tbWhereIdUpdCountry.Text))
                return;

            try {
                using (MySqlCommand update = new MySqlCommand(
                    "UPDATE country SET " +
                    "country_id=@country_id, " +
                    "country_name=@country_name, " +
                    "population=@population, " +
                    "area=@area, " +
                    "continent=@continent, " +
                    "currency=@currency, " +
                    "official_lan=@official_lan, " +
                    "capital=@capital " +
                    "WHERE country_id=@idWhere",
                    sqlConnection)) {

                    update.Parameters.AddWithValue("country_id", tbIdUpdCountry.Text);
                    update.Parameters.AddWithValue("country_name", tbUpdNameCountry.Text);
                    update.Parameters.AddWithValue("population", tbPopulationUpdCountry.Text);
                    update.Parameters.AddWithValue("area", tbUpdAreaCountry.Text);
                    update.Parameters.AddWithValue("continent", tbUpdContinentCountry.Text);
                    update.Parameters.AddWithValue("currency", tbUpdCurrencyCountry.Text);
                    update.Parameters.AddWithValue("official_lan", tbUpdLangCountry.Text);
                    update.Parameters.AddWithValue("capital", tbUpdCapitalCountry.Text);
                    update.Parameters.AddWithValue("idWhere", tbWhereIdUpdCountry.Text);

                    await update.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void UPDATE_capital_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbUpdIdCapital.Text) || String.IsNullOrWhiteSpace(tbWhereIdUpdCapital.Text))
                return;

            try {
                using (MySqlCommand update = new MySqlCommand(
                    "UPDATE capital SET " +
                    "city_id=@city_id, " +
                    "city_name=@city_name, " +
                    "country_id=@country_id, " +
                    "population=@population " +
                    "WHERE city_id=@idWhere",
                    sqlConnection)) {

                    update.Parameters.AddWithValue("city_id", tbUpdIdCapital.Text);
                    update.Parameters.AddWithValue("city_name", tbUpdNameCapital.Text);
                    update.Parameters.AddWithValue("country_id", tbUpdIdCountryCapital.Text);
                    update.Parameters.AddWithValue("population", tbUpdPopulationCapital.Text);
                    update.Parameters.AddWithValue("idWhere", tbWhereIdUpdCapital.Text);

                    await update.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void UPDATE_currency_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbUpdIdCurrency.Text) || String.IsNullOrWhiteSpace(tbWhereIdUpdCurrency.Text))
                return;

            try {
                using (MySqlCommand update = new MySqlCommand(
                    "UPDATE currency SET " +
                    "currency_id=@currency_id, " +
                    "currency=@currency, " +
                    "exchange_rate=@exchange_rate " +
                    "WHERE currency_id=@idWhere",
                    sqlConnection)) {

                    update.Parameters.AddWithValue("currency_id", tbUpdIdCurrency.Text);
                    update.Parameters.AddWithValue("currency", tbUpdNameCurrency.Text);
                    update.Parameters.AddWithValue("exchange_rate", tbUpdExRateCurrency.Text);
                    update.Parameters.AddWithValue("idWhere", tbWhereIdUpdCurrency.Text);

                    await update.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void UPDATE_continent_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbUpdIdContinent.Text) || String.IsNullOrWhiteSpace(tbWhereIdUpdContinent.Text))
                return;

            try {
                using (MySqlCommand update = new MySqlCommand(
                    "UPDATE continent SET " +
                    "id_continent=@id_continent, " +
                    "continent=@continent " +
                    "WHERE id_continent=@idWhere",
                    sqlConnection)) {

                    update.Parameters.AddWithValue("id_continent", tbUpdIdContinent.Text);
                    update.Parameters.AddWithValue("continent", tbUpdNameContinent.Text);
                    update.Parameters.AddWithValue("idWhere", tbWhereIdUpdContinent.Text);

                    await update.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void button12_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbUpdIdLanguage.Text) || String.IsNullOrWhiteSpace(tbWhereIdUpdLanguage.Text))
                return;

            try {
                using (MySqlCommand update = new MySqlCommand(
                    "UPDATE language SET " +
                    "language_id=@language_id, " +
                    "language_name=@language_name, " +
                    "percentage=@percentage " +
                    "WHERE language_id=@idWhere",
                    sqlConnection)) {

                    update.Parameters.AddWithValue("language_id", tbUpdIdLanguage.Text);
                    update.Parameters.AddWithValue("language_name", tbUpdNameLanguage.Text);
                    update.Parameters.AddWithValue("percentage", tbUpdPercentLanguage.Text);
                    update.Parameters.AddWithValue("idWhere", tbWhereIdUpdLanguage.Text);

                    await update.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }
        //---

        // INSERT COMMAND
        private async void INSERT_country_Click(object sender, EventArgs e) {
            try {
                using (MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO country (country_id, country_name, population, area, continent, currency, official_lan, capital)VALUES(@country_id, @country_name, @population, @area, @continent, @currency, @official_lan, @capital)",
                    sqlConnection)) {
                    insert.Parameters.AddWithValue("country_id", tbIdInsertCountry.Text);
                    insert.Parameters.AddWithValue("country_name", tbNameInsertCountry.Text);
                    insert.Parameters.AddWithValue("population", tbPopulationInsertCountry.Text);
                    insert.Parameters.AddWithValue("area", tbAreaInsertCountry.Text);
                    insert.Parameters.AddWithValue("continent", tbContinentInsertCountry.Text);
                    insert.Parameters.AddWithValue("currency", tbCurrencyInsertCountry.Text);
                    insert.Parameters.AddWithValue("official_lan", tbLangInsertCountry.Text);
                    insert.Parameters.AddWithValue("capital", tbCapitalInsertCountry.Text);
                    await insert.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void INSERT_capital_Click(object sender, EventArgs e) {
            try {
                using (MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO capital (city_id, city_name, country_id, population)VALUES(@city_id, @city_name, @country_id, @population)", sqlConnection)) {
                    insert.Parameters.AddWithValue("city_id", tbInsertCapitalId.Text);
                    insert.Parameters.AddWithValue("city_name", tbInsertCapitalName.Text);
                    insert.Parameters.AddWithValue("country_id", tbInsertCountryId.Text);
                    insert.Parameters.AddWithValue("population", tbInsertPopulation.Text);
                    await insert.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void INSERT_continent_Click(object sender, EventArgs e) {
            try {
                using (MySqlCommand insert = new MySqlCommand("INSERT INTO continent (id_continent, continent)VALUES(@id_continent, @continent)", sqlConnection)) {
                    insert.Parameters.AddWithValue("id_continent", tbInsertContinentIdContinent.Text);
                    insert.Parameters.AddWithValue("continent", tbInsertContinentName.Text);
                    await insert.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void INSERT_language_Click(object sender, EventArgs e) {
            try {
                using (MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO language (language_id, language_name, percentage)VALUES(@language_id, @language_name, @percentage)", sqlConnection)) {
                    insert.Parameters.AddWithValue("language_id", tbInsertLangIDLang.Text);
                    insert.Parameters.AddWithValue("language_name", tbInsertLangName.Text);
                    insert.Parameters.AddWithValue("percentage", tbInsertLangPercent.Text);
                    await insert.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }

        private async void INSERT_currency_Click(object sender, EventArgs e) {
            try {
                using (MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO currency (currency_id, currency, exchange_rate)VALUES(@currency_id, @currency, @exchange_rate)", sqlConnection)) {
                    insert.Parameters.AddWithValue("currency_id", tbInsertCurrencyId.Text);
                    insert.Parameters.AddWithValue("currency", tbInsertCurrencyName.Text);
                    insert.Parameters.AddWithValue("exchange_rate", tbInsertCurrencyExRate.Text);
                    await insert.ExecuteNonQueryAsync();
                }
                UpdateSelect();
            }
            catch { }
        }
        //---

        // DELETE COMMAND
        private async void DELETE_country_Click(object sender, EventArgs e) {
            using (MySqlCommand delete = new MySqlCommand(
                "DELETE FROM country WHERE country_id = @country_id", sqlConnection)) {
                try {
                    delete.Parameters.AddWithValue("country_id", tbCountryDelete.Text);
                    await delete.ExecuteNonQueryAsync();
                }
                catch {
                    lbError.Text = String.Empty;
                }
            }
            UpdateSelect();
        }

        private async void DELETE_capital_Click(object sender, EventArgs e) {
            using (MySqlCommand delete = new MySqlCommand("DELETE FROM capital WHERE city_id = @city_id", sqlConnection)) {
                try {
                    delete.Parameters.AddWithValue("city_id", tbCapitalDelete.Text);
                    await delete.ExecuteNonQueryAsync();
                }
                catch {
                    lbError.Text = String.Empty;
                }
            }
            UpdateSelect();
        }

        private async void DELETE_language_Click(object sender, EventArgs e) {
            using (MySqlCommand delete = new MySqlCommand("DELETE FROM language WHERE language_id = @language_id", sqlConnection)) {
                try {
                    delete.Parameters.AddWithValue("language_id", tbLanguageDelete.Text);
                    await delete.ExecuteNonQueryAsync();
                }
                catch {
                    lbError.Text = String.Empty;
                }
            }
            UpdateSelect();
        }

        private async void DELETE_currency_Click(object sender, EventArgs e) {
            using (MySqlCommand delete = new MySqlCommand("DELETE FROM currency WHERE currency_id = @currency_id", sqlConnection)) {
                try {
                    delete.Parameters.AddWithValue("currency_id", tbCurrencyDelete.Text);
                    await delete.ExecuteNonQueryAsync();
                }
                catch {
                    lbError.Text = String.Empty;
                }
            }
            UpdateSelect();
        }

        private async void DELETE_continent_Click(object sender, EventArgs e) {
            using (MySqlCommand delete = new MySqlCommand("DELETE FROM continent WHERE id_continent = @id_continent", sqlConnection)) {
                try {
                    delete.Parameters.AddWithValue("id_continent", tbContinentDelete.Text);
                    await delete.ExecuteNonQueryAsync();
                }
                catch {
                    lbError.Text = String.Empty;
                }
            }
            UpdateSelect();
        }
        //---

        //METHODS
        bool IsConnClose = false;
        private async void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!IsConnClose) {
                await sqlConnection.CloseAsync();
                отключитьсяToolStripMenuItem.Text = "Подключиться";
                lbStatus.Text = "Статус: Отключено";
                lbStatus.ForeColor = Color.Red;
            }
            else {

                try {
                    await sqlConnection.OpenAsync();
                    UpdateSelect();
                }
                catch {
                    lbStatus.Text = "Статус: Ошибка подключения";
                    lbStatus.ForeColor = Color.Red;
                    return;
                }

                lbStatus.Text = "Статус: Подключено";
                отключитьсяToolStripMenuItem.Text = "Отключиться";
                lbStatus.ForeColor = Color.Green;
            }
            IsConnClose = !IsConnClose;
        }

        private void добавитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e) {
            DbLocaionForm form = new DbLocaionForm();
            form.DbConnect += Form_DbConnect;
            form.ShowDialog(this);
        }

        private void Form_DbConnect(MySqlConnection sqlConnection) {
            this.sqlConnection = sqlConnection;
            lbStatus.Text = "Статус: Подключено";
            lbStatus.ForeColor = Color.Green;
            обновитьБазуДанныхToolStripMenuItem.Enabled = true;
            отключитьсяToolStripMenuItem.Enabled = true;

            string[] nameSplit = sqlConnection.ConnectionString.Split('=');
            String DbName = nameSplit[nameSplit.Length - 1];
            lbDbName.Text = $"База данных ({DbName})";
            UpdateSelect();
        }

        private void Update_MenuStrip(object sender, EventArgs e) => UpdateSelect();

        private void Exit_MenuStrip(object sender, EventArgs e) => Close();

        private void tabControl3_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.N) {
                ChangeNameForm form = new ChangeNameForm();
                form.ProgramNameChange += (Name) => Text = Name;
                form.ShowDialog();
            }
        }
    }
}
