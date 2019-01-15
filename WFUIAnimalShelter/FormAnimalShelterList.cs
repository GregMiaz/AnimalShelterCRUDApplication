using SOCAnimalShelterDataMigration.Controllers;
using SOCAnimalShelterDataMigration.Models;
using System;
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
            dataGridViewAnimals.Columns["Weight"].Visible = false;
            dataGridViewAnimals.Columns["DateOfBirth"].Visible = false;
            

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimals.SelectedRows.Count > 0)
            {
                const int dateTimeTruncateIndex = 10;
                string result = string.Format("Name: {0}\n", dataGridViewAnimals.SelectedRows[0].Cells[1].Value.ToString());
                result += string.Format("Species: {0}\n", dataGridViewAnimals.SelectedRows[0].Cells[2].Value.ToString());
                result += string.Format("Date of Birth: {0}\n", dataGridViewAnimals.SelectedRows[0].Cells[3].Value.ToString().Remove(dateTimeTruncateIndex));
                result += string.Format("Weight: {0} kg",dataGridViewAnimals.SelectedRows[0].Cells[4].Value.ToString());
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

        private void dataGridViewAnimals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Animal animalToEdit = (Animal)dataGridViewAnimals.Rows[e.RowIndex].DataBoundItem;

            var editController = new EditController();
            editController.EditAnimal(animalToEdit);
        }
    }
}
