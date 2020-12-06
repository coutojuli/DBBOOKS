using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juliana_N01348498_Project
{
    public partial class Form1 : Form
    {
        public int id { get; set; }
        public string title { get; set; }

        public double price { get; set; }

        public Form1()
        {
            InitializeComponent();

        }
        private void selectRowsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.SelectRows(this.iTS5230DataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            string connectionString;
            try
            {
                connectionString = @"Data Source=localhost;Initial Catalog=ITS5230;Persist Security Info=True;User ID=juliana_N01348498;Password=123";

                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection test was successfull!");

                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (Exception sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.SelectRows();
        }

        private void SelectRows()
        {
            SqlConnection connection;
            string connectionString;
            try
            {
                connectionString = @"Data Source=localhost;Initial Catalog=ITS5230;Persist Security Info=True;User ID=juliana_N01348498;Password=123";

                connection = new SqlConnection(connectionString);
                connection.Open();

                string query;

                query = "SELECT * FROM Books";

                var dataAdapter = new SqlDataAdapter(query, connection);
                var command = new SqlCommandBuilder(dataAdapter);
                var dataset = new DataSet();

                dataAdapter.Fill(dataset);

                gvTableGrid.DataSource = null;
                gvTableGrid.Columns.Clear();
                gvTableGrid.Rows.Clear();
                gvTableGrid.ReadOnly = true;
                gvTableGrid.DataSource = dataset.Tables[0];

                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (Exception sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }
        private void SortGrid()
        {
            SqlConnection connection;
            string connectionString;
            try
            {
                connectionString = @"Data Source=localhost;Initial Catalog=ITS5230;Persist Security Info=True;User ID=juliana_N01348498;Password=123";

                connection = new SqlConnection(connectionString);
                connection.Open();

                string query;

                string value = cbSort.SelectedItem.ToString();
                string handler = "";
                
                switch (value)
                {
                    case ("ID"):
                    {
                        handler= "SELECT * FROM Books ORDER BY book_id";
                        break;
                    }
                    case ("Title"):
                    {
                        handler = "SELECT * FROM Books ORDER BY book_title";
                        break;
                    }
                    case ("Price"):
                    {
                        handler = "SELECT * FROM Books ORDER BY book_price";
                        break;
                    }
                    default:
                    break;
                }
                query = handler;

                var dataAdapter = new SqlDataAdapter(query, connection);
                var command = new SqlCommandBuilder(dataAdapter);
                var dataset = new DataSet();

                dataAdapter.Fill(dataset);

                gvTableGrid.DataSource = null;
                gvTableGrid.Columns.Clear();
                gvTableGrid.Rows.Clear();
                gvTableGrid.ReadOnly = true;
                gvTableGrid.DataSource = dataset.Tables[0];

                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (Exception sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }

        private void DeleteRow()
        {
            SqlConnection connection;
            string connectionString;
            try
            {
                connectionString = @"Data Source=localhost;Initial Catalog=ITS5230;Persist Security Info=True;User ID=juliana_N01348498;Password=123";

                connection = new SqlConnection(connectionString);
                connection.Open();

                string query;

                if (txtDelete.TextLength > 0)
                {
                    string delete_handler = txtDelete.Text;

                    string query_delete = " Delete FROM Books WHERE book_title = @title";
                    SqlCommand command_delete = new SqlCommand(query_delete, connection);
                    command_delete.Parameters.AddWithValue("@title", delete_handler);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();

                    dataAdapter.DeleteCommand = command_delete;
                    int count = dataAdapter.DeleteCommand.ExecuteNonQuery();

                    this.SelectRows();
                    if (count >= 1)
                    {
                        MessageBox.Show("Delete action was successfull!");
                    }
                    else
                    {
                        MessageBox.Show("Delete action was not successfull! Try again with right title");
                    }

                    if (connection != null)
                    {
                        connection.Close();
                        dataAdapter.Dispose();
                        command_delete.Dispose();
                    }
                }
            }
            catch (Exception sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }

        private void ExportFile()
        {
            SqlConnection connection;
            string connectionString;
            try
            {
                connectionString = @"Data Source=localhost;Initial Catalog=ITS5230;Persist Security Info=True;User ID=juliana_N01348498;Password=123";

                string query = @"SELECT book_id,book_title,book_price FROM Books";
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                StreamWriter fileName = new StreamWriter(@"C:\Users\Juliana\Desktop\Humber\Segundo Termo\Windows App\fileName.tsv");

                try
                {
                    fileName.WriteLine("book_id\tbook_title\tbook_price");
                    while (reader.Read())
                    {
                        fileName.WriteLine(String.Format("{0}\t{1}\t{2}",
                            reader["book_id"],reader["book_title"],reader["book_price"]));
                    }
                    lblFilename.Text = "File: fileName.tsv";
                    MessageBox.Show("File creation successful. Database was exported.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    reader.Close();
                    fileName.Close();
                    connection.Close();
                }
            }
            catch (Exception sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex > -1)
            {
                this.SortGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this title?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.DeleteRow();
            }
            else
            {
                MessageBox.Show("Delete action cancelled");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportFile();
        }
    }
}

