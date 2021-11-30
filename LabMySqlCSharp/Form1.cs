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

            private String buildConnectionUtil() {
                return "Server=" + connectionHostname + 
                    "; Database=" + connectionDatabaseName + 
                    "; User ID=" + connectionUsername +
                    "; Password=" + connectionPassword;
            }

            public void buildConnection() {
                connection = new MySqlConnection(buildConnectionUtil());
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
            clearAll();
            DB.init(textBoxHostname.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxDatabaseName.Text, textBoxTablename.Text);
            DB.buildConnection();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("select * from " + DB.connectionTableName, DB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            DB.closeConnection();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            dataGridView1.EndEdit();
            DataTable changedRows = table.GetChanges();
            if (changedRows != null) {
                MySqlCommandBuilder command = new MySqlCommandBuilder(adapter);
                adapter.Update(changedRows);
                table.AcceptChanges();
                MessageBox.Show("Changes saved");
            }
        }

        private void clearAll() {
            table.Clear();
        }
    }
}
