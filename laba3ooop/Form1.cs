using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3ooop
{
    public partial class Form1 : Form
    {

        private List<MyData> dataList = new List<MyData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);
                        dataList = JsonConvert.DeserializeObject<List<MyData>>(jsonContent);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Opening file error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                        File.WriteAllText(saveFileDialog.FileName, jsonContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Opening file error: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                dataList.Add(editForm.Data);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataList;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MyData selectedData = dataGridView1.CurrentRow.DataBoundItem as MyData;
                if (selectedData != null)
                {
                    EditForm editForm = new EditForm(selectedData);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MyData selectedData = dataGridView1.CurrentRow.DataBoundItem as MyData;
                if (selectedData != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        dataList.Remove(selectedData);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                    }
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чорномаз Артем Вадимович\n2 курс\nК-23", "About program");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class MyData
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
