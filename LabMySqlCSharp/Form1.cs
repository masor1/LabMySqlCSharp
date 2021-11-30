using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LabMySqlCSharp {
    public partial class Form1 : Form {

        private Databace DB;
        private DataTable table;
        private MySqlDataAdapter adapter;

        public class Databace {

            public String connectionHostname;
            public String connectionUsername;
            public String connectionPassword;
            public String connectionDatabaseName;
            public String connectionTableName;

            MySqlConnection connection;

            public void init(
                String connectionHostname, 
                String connectionUsername,
                String connectionPassword,
                String connectionDatabaseName,
                String connectionTableName
                ) {
                this.connectionHostname = connectionHostname;
                this.connectionUsername = connectionUsername;
                this.connectionPassword = connectionPassword;
                this.connectionDatabaseName = connectionDatabaseName;
                this.connectionTableName = connectionTableName;
            }

            public void init (
                String connectionHostname,
                String connectionUsername,
                String connectionPassword
                ) {
                this.connectionHostname = connectionHostname;
                this.connectionUsername = connectionUsername;
                this.connectionPassword = connectionPassword;
            }

            private String buildConnectionUtil() {
                return "Server=" + connectionHostname + 
                    "; Database=" + connectionDatabaseName + 
                    "; User ID=" + connectionUsername +
                    "; Password=" + connectionPassword;
            }

            private String buildConnectionUtilFind () {
                return "Server=" + connectionHostname +
                    "; User ID=" + connectionUsername +
                    "; Password=" + connectionPassword;
            }

            public void buildConnection() {
                connection = new MySqlConnection(buildConnectionUtil());
            }

            public void buildConnectionFind () {
                connection = new MySqlConnection(buildConnectionUtilFind());
            }

            public void openConnection() {
                if (connection.State == ConnectionState.Closed) {
                    connection.Open();
                }
            }

            public void closeConnection() {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }

            public MySqlConnection getConnection() {
                return connection;
            }
        }

        public Form1() {
            InitializeComponent();
            DB = new Databace();
            table = new DataTable();
            adapter = new MySqlDataAdapter();
            textBoxHostname.Text = "localhost";
            textBoxUsername.Text = "root";
        }

        private void loadButton_Click(object sender, EventArgs e) {
            load();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            save();
        }

        private void buttonQueryFind_Click (object sender, EventArgs e) {
            find();
        }

        private void buttonOrderExecute_Click (object sender, EventArgs e) {
            oprderExecute();
        }

        private void load () {
            try {
                clearAll();
                DB.init(textBoxHostname.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxDatabaseName.Text, textBoxTablename.Text);
                DB.buildConnection();
                DB.openConnection();
                MySqlCommand command = new MySqlCommand("select * from " + DB.connectionTableName, DB.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                DB.closeConnection();
            } catch (Exception exception) {
                showExceptionDialog(exception);
            }
        }

        private void save () {
            try {
                dataGridView1.EndEdit();
                DataTable changedRows = table.GetChanges();
                if (changedRows != null) {
                    MySqlCommandBuilder command = new MySqlCommandBuilder(adapter);
                    adapter.Update(changedRows);
                    table.AcceptChanges();
                    MessageBox.Show("Changes saved");
                }
            } catch (Exception exception) {
                showExceptionDialog(exception);
            }
        }

        private void find () {
            try {
                clearAll();
                DB.init(textBoxHostname.Text, textBoxUsername.Text, textBoxPassword.Text);
                DB.buildConnectionFind();
                DB.openConnection();
                MySqlCommand sqlCommand = new MySqlCommand(textBoxQuery.Text, DB.getConnection());
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                DB.closeConnection();
            } catch (Exception exception) {
                showExceptionDialog(exception);
            }
        }

        private void oprderExecute () {
            try {
                DB.init(textBoxHostname.Text, textBoxUsername.Text, textBoxPassword.Text);
                DB.buildConnectionFind();
                DB.openConnection();
                MySqlCommand sqlCommand = new MySqlCommand(
                    createSqlCall(textBoxOrderBuyer.Text, textBoxOrderProduct.Text, textBoxOrderCount.Text),
                    DB.getConnection()
                    );
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
                DB.closeConnection();
            } catch (Exception exception) {
                showExceptionDialog(exception);
            }
        }

        private String createSqlCall (String buyer, String product, String count) {
            return "call " + textBoxDatabaseName.Text +
                    ".createOrder(" +
                    buyer + "," +
                    product + "," +
                    count +
                    ");";
        }

        private void showExceptionDialog (Exception exception) {
            MessageBox.Show("Поля заполнены некорректно!\n\n" + exception.Message);
        }

        private void clearAll() {
            table.Clear();
        }
    }
}
