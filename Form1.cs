//********************************************************************************
//********************************************************************************
// Application Developer: AuNyx LLC
// Programmer: Elijah D Brown, contact: elijahbrown171@gmail.com
// Publish Date: 03.19.2023
//********************************************************************************
//********************************************************************************

using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExcelDataReader;
using System.Collections.Generic;
using System.Linq;

namespace Excel_to_SQL_Import_Wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Load the user's saved settings
            serverInstanceTextBox.Text = Properties.Settings.Default.ServerInstanceName;
            databaseNameTextBox.Text = Properties.Settings.Default.DatabaseNameSet;
            usernameTextBox.Text = Properties.Settings.Default.UsernameSet;
            passwordTextBox.Text = Properties.Settings.Default.PasswordSet;
            tableTextBox.Text = Properties.Settings.Default.TableNameSet;
            columnsTextBox.Text = Properties.Settings.Default.ColumnNamesSet;
        }

        private void saveSettingsButton1_Click_1(object sender, EventArgs e)
        {
            // Save the user's input for the target SQL connection
            Properties.Settings.Default.ServerInstanceName = serverInstanceTextBox.Text;
            Properties.Settings.Default.DatabaseNameSet = databaseNameTextBox.Text;
            Properties.Settings.Default.UsernameSet = usernameTextBox.Text;
            Properties.Settings.Default.PasswordSet = passwordTextBox.Text;
            Properties.Settings.Default.Save();

            // Debug message(s)
            Console.WriteLine("Saved ServerInstanceName: " + Properties.Settings.Default.ServerInstanceName);
            Console.WriteLine("Saved DatabaseNameSet: " + Properties.Settings.Default.DatabaseNameSet);
            Console.WriteLine("Saved UsernameSet: " + Properties.Settings.Default.UsernameSet);
            Console.WriteLine("Saved PasswordSet: " + Properties.Settings.Default.PasswordSet);

            // Show a message box indicating the settings have been saved
            MessageBox.Show("SQL Database connection settings have been saved successfully.");
        }

        private void saveSettingsButton2_Click_1(object sender, EventArgs e)
        {
            // Save the user's input for the target SQL table
            Properties.Settings.Default.TableNameSet = tableTextBox.Text;
            Properties.Settings.Default.ColumnNamesSet = columnsTextBox.Text;
            Properties.Settings.Default.Save();

            // Debug message(s)
            Console.WriteLine("Saved TableNameSet: " + Properties.Settings.Default.TableNameSet);
            Console.WriteLine("Saved ColumnNamesSet: " + Properties.Settings.Default.ColumnNamesSet);

            // Show a message box indicating the settings have been saved
            MessageBox.Show("SQL Table settings have been saved successfully.");
        }

        private void selectFileButton_Click_1(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to let the user choose an Excel file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the OpenFileDialog's file filter to display only Excel workbooks and all files
                openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Excel Workbook";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Update the label control with the selected file path
                    filePathLabel.Text = selectedFilePath;
                }
            }
        }

        private void uploadDataButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if the file path is empty; if so, show a message box and exit the method
                if (string.IsNullOrEmpty(filePathLabel.Text))
                {
                    MessageBox.Show("Select an Excel file to upload data from.");
                    return;
                }

                // Create a connection string for connecting to the SQL Server using specified server instance, database name, username, and password, with a 60-second timeout
                string connectionString1 = $"Server={serverInstanceTextBox.Text};Initial Catalog={databaseNameTextBox.Text};User ID={usernameTextBox.Text};Password={passwordTextBox.Text};Trusted_Connection = False;Connect Timeout=60";

                // Open the Excel file and create a reader for its content
                using (FileStream fs = File.Open(filePathLabel.Text, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs))
                    {
                        var config = new ExcelDataSetConfiguration
                        {
                            // Set the ExcelDataTableConfiguration to use the first row as header/column names
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true
                            }
                        };

                        // Convert Excel data to a DataSet and get the first table
                        DataSet result = reader.AsDataSet(config);
                        DataTable table = result.Tables[0];

                        using (SqlConnection conn = new SqlConnection(connectionString1))
                        {
                            conn.Open();
                            int numberOfRows = 0;

                            // Retrieve table name and columns from saved settings
                            Properties.Settings.Default.Reload();
                            string tableName = Properties.Settings.Default.TableNameSet;
                            string columnsText = Properties.Settings.Default.ColumnNamesSet;

                            // Parse column definitions and store them in a list
                            List<string> columnPairs = columnsText.Split(';').Select(x => x.Trim()).ToList();
                            List<(string Name, SqlDbType Type)> columns = new List<(string Name, SqlDbType Type)>();

                            foreach (string pair in columnPairs)
                            {
                                // Split the column definition pair by comma, trim whitespace, and store in an array
                                string[] columnData = pair.Split(',').Select(x => x.Trim()).ToArray();
                                if (columnData.Length == 2)
                                {
                                    columns.Add((columnData[0], (SqlDbType)Enum.Parse(typeof(SqlDbType), columnData[1])));
                                }
                            }

                            // Setup an INSERT INTO command to insert data into the specified table
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = conn;
                                cmd.CommandTimeout = 60;

                                string columnsString = string.Join(", ", columns.Select(c => c.Name));
                                string parametersString = string.Join(", ", columns.Select(c => "@" + c.Name));
                                string query = $"INSERT INTO {tableName} ({columnsString}) VALUES ({parametersString})";
                                cmd.CommandText = query;

                                // Add parameters to the command
                                cmd.Parameters.Clear();
                                foreach (var column in columns)
                                {
                                    cmd.Parameters.Add("@" + column.Name, column.Type);
                                }

                                // Execute the command for each row in the DataTable
                                foreach (DataRow row in table.Rows)
                                {
                                    foreach (var column in columns)
                                    {
                                        cmd.Parameters["@" + column.Name].Value = row[column.Name];
                                    }

                                    numberOfRows += cmd.ExecuteNonQuery();
                                }

                                // Debug message
                                Console.WriteLine(query);
                            }

                            // Show a message box indicating the number of rows inserted
                            MessageBox.Show("Upload successful: Inserted " + numberOfRows + " rows.");
                        }
                    }
                }
            }

            // Show any error messages, and display them by type
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}