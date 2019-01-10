using SOCAnimalShelterDataMigration.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUIAnimalShelter
{
    public partial class FormAnimalShelterList : Form
    {
        public FormAnimalShelterList()
        {
            InitializeComponent();

            var readController = new ReadController();
            dataGridViewAnimals.DataSource = readController.ReadAnimals();
            dataGridViewAnimals.Columns["Id"].Visible = false;
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimals.SelectedRows.Count > 0)
            {
                string result = "Name: " + dataGridViewAnimals.SelectedRows[0].Cells[1].Value.ToString();
                result += ", Species: " + dataGridViewAnimals.SelectedRows[0].Cells[2].Value.ToString();
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("You must select whole row.");
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAnimalShelterAddNew = new FormAnimalShelterAddNew(dataGridViewAnimals);
            formAnimalShelterAddNew.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimals.SelectedRows.Count > 0)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Are you sure you want to delete this animal?", "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var deleteController = new DeleteController();
                    int id = Convert.ToInt32(dataGridViewAnimals.SelectedRows[0].Cells[0].Value);
                    deleteController.DeleteAnimal(id);
                    MessageBox.Show("You successully deleted animal from a list");
                    var readController = new ReadController();
                    dataGridViewAnimals.DataSource = readController.ReadAnimals();
                }
            }
            else
            {
                MessageBox.Show("You must select whole row.");
            }

        }
    }
}
