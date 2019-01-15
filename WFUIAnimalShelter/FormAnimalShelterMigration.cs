using SOCAnimalShelterDataMigration.Controllers;
using SOCAnimalShelterDataMigration.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUIAnimalShelter
{
    public partial class FormAnimalShelterMigration : Form
    {
        public FormAnimalShelterMigration()
        {
            InitializeComponent();
        }

        private void buttonMigration_Click(object sender, EventArgs e)
        {
            var migrationController = new MigrationController();
            migrationController.FileToDatabaseMigration(textBoxPath.Text);
            MessageBox.Show("Successful data migration", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonShowAnimals_Click(object sender, EventArgs e)
        {
            var formAnimalShelterList = new FormAnimalShelterList();
            formAnimalShelterList.Show();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            var createTableManager = new CreateTableManager();
            createTableManager.CreateAnimalTable();
            MessageBox.Show("Success", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonCreateTable.Enabled = false;
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = Path.GetFullPath(openFileDialog.FileName);
            }
        }
        
    }
}
