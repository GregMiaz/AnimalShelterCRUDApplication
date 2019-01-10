using SOCAnimalShelterDataMigration.Controllers;
using SOCAnimalShelterDataMigration.Models;
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
    public partial class FormAnimalShelterAddNew : Form
    {
        private DataGridView _dataGridViewAnimals;

        public FormAnimalShelterAddNew(DataGridView dataGridViewAnimals)
        {
            InitializeComponent();
            _dataGridViewAnimals = dataGridViewAnimals;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newAnimal = new Animal();
            newAnimal.Name = textBoxName.Text;
            newAnimal.Species = textBoxSpecies.Text;
            newAnimal.Weight = Convert.ToInt32(numericUpDownWeight.Value);
            newAnimal.DateOfBirth = dateTimePickerDateOfBirth.Value;
            
            AddController addController = new AddController();
            addController.AddAnimal(newAnimal);

            var readController = new ReadController();
            _dataGridViewAnimals.DataSource = readController.ReadAnimals();


            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void buttonReturnToList_Click(object sender, EventArgs e)
        {
            var formAnimalShelterList = new FormAnimalShelterList();
            formAnimalShelterList.Show();
            this.Close();
        }
    }
}
