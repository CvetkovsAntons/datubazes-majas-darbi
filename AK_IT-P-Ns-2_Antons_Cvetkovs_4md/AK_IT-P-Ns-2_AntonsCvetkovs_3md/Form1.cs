using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_IT_P_Ns_2_AntonsCvetkovs_3md
{
    public partial class Form1 : Form
    {
        private Model model;
        private readonly Database database;

        public Form1()
        {
            database = new Database(); // veidojam datu bazes objektu
            InitializeComponent();
        }

        private Type getModelType(string table = null) // funkcija atgriez modeles objekta data tipu
        {
            return table == null ? model.GetType() : Type.GetType($"AK_IT_P_Ns_2_AntonsCvetkovs_3md.{table}");
        }

        private void setModel(string table) // funkcija veido izveletas modeles objektu
        {
            model = (Model)Activator.CreateInstance(getModelType(table));
        }

        private List<string> getColumns() // funkcija, kas izsauc metodi modeles klase, kas atgriez ta kolonnas
        {
            return (List<string>)typeof(Model).GetMethod("GetColumns").MakeGenericMethod(getModelType()).Invoke(model, null);
        }

        private void getAllRows() // funkcija, kas izsauc metodi modeles klase, kas atgriez visus tabulas ierakstuts
        {
            MethodInfo get_all = typeof(Model).GetMethod("GetAll").MakeGenericMethod(getModelType());
            getRows((DataTable)get_all.Invoke(model, null));
        }

        private void getSearchRows() // funkcija, kas izsauc metodi modeles klase, kas atgriez tabulas ierakstuts pec vertibas
        {
            MethodInfo search = typeof(Model).GetMethod("Search").MakeGenericMethod(getModelType());
            object[] parameters = { searchDropDown.SelectedValue, searchInput.Text };
            getRows((DataTable)search.Invoke(model, parameters));
        }

        private void getRows(DataTable rows) // funkcija, kas peivieno vertibas formaa
        {
            dataGridView1.DataSource = rows;
            totalRowsCountText.Text = rows.Rows.Count.ToString();
            totalRowsText.Visible = totalRowsCountText.Visible = dataGridView1.Visible = true;
            searchInput.Text = "";
        }

        public void loadTableData(object sender, EventArgs e) // funkcija, kas peivieno tabulas datus formaa
        {
            string current_table = (sender as Button).Text;
            tableNameText.Text = current_table;
            setModel(current_table.Substring(0, current_table.Length - 1));
            searchDropDown.DataSource = getColumns();
            getAllRows();
            removeElementsStartingWith("addLabel");
            removeElementsStartingWith("addTextBox");
            createTextboxes();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getSearchRows();
        }

        private void deleteAllButton_Click(object sender, EventArgs e) // izdes visus datus
        {
            database.DeleteAllData();
            getAllRows();
        }

        private void importDataButton_Click(object sender, EventArgs e) // inmportejam datus
        {
            OpenFileDialog file = new OpenFileDialog // atveram dialogu, kuraa var izveleties csv failu
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Select a CSV File"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // izsaucam funkciju, kas importe datus
                    object[] parameters = { file.FileName };
                    typeof(Model).GetMethod("ImportData").MakeGenericMethod(getModelType()).Invoke(model, parameters);
                    getAllRows();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading data. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) // izdes izveletas rindas
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // dabunam primaram atslega nosaukumu
                string pk = (string)typeof(Model).GetMethod("GetPrimaryKey").MakeGenericMethod(getModelType()).Invoke(model, null);
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    if (selectedRow.DataBoundItem is DataRowView dataRowView)
                    {
                        object[] parameters = { dataRowView.Row[pk].ToString() };
                        typeof(Model).GetMethod("Delete").MakeGenericMethod(getModelType()).Invoke(model, parameters);
                    }
                }
                getAllRows();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void createTextboxes() // funkcija, kas uzzime textboxus ierakstu pievienosanai
        {
            int x = 930;
            int y = 120;

            foreach (string column in getColumns())
            {
                if (column != "id" && column != "date")
                {
                    Label label = new Label();
                    label.Name = "addLabel_" + column;
                    label.Text = column;
                    label.Location = new Point(x, y);
                    this.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Name = "addTextBox_" + column;
                    textBox.Location = new Point(x, y + 24);
                    this.Controls.Add(textBox);

                    y += 50;
                }
            }
        }

        private void removeElementsStartingWith(string prefix) // funkcija, kas nodzes elementus, kas sakas ar noradito prefiksu
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in this.Controls)
            {
                if (control.Name != null && control.Name.StartsWith(prefix))
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control controlToRemove in controlsToRemove)
            {
                this.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }

        private void addButton_Click(object sender, EventArgs e) // pievienojam jaunu ierakstu
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            foreach (string column in getColumns())
            {
                if (column != "id" && column != "date")
                {
                    // atrodam kolonnas text boxu
                    TextBox text_box = this.Controls.Find("addTextBox_" + column, true).FirstOrDefault() as TextBox;

                    if (text_box != null)
                    {
                        // pievienojam kolonas nosaukumu un ta vertibu sarakstaa
                        data.Add(column, text_box.Text);
                    }
                    else
                    {
                        MessageBox.Show($"TextBox not found for column: {column}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            object[] parameters = { data };
            typeof(Model).GetMethod("Create").MakeGenericMethod(getModelType()).Invoke(model, parameters);
            getAllRows();
        }

        private void saveButton_Click(object sender, EventArgs e) // saglabajam izmainas ierakstos
        {
            string pk = (string)typeof(Model).GetMethod("GetPrimaryKey").MakeGenericMethod(getModelType()).Invoke(model, null);
            foreach (DataRow row in ((DataTable)dataGridView1.DataSource).Rows)
            {
                if (row.RowState == DataRowState.Modified) // ja ieraksts bija modificets, tad update to
                {
                    object[] parameters = { row, row[pk, DataRowVersion.Original] };
                    typeof(Model).GetMethod("Update").MakeGenericMethod(getModelType()).Invoke(model, parameters);
                }
            }
            getAllRows();
        }
    }
}
