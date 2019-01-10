using SOCAnimalShelterDataMigration.Controllers;
using SOCAnimalShelterDataMigration.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWFUIAnimalShelter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void buttonMigration_Click(object sender, EventArgs e)
        {
            var migrationController = new MigrationController();
            migrationController.FileToDatabaseMigration(TextBoxPath.Text);
            labelMigrationResult.Text = "Successful data migration.";

        }

        protected void buttonShowAnimals_Click(object sender, EventArgs e)
        {
            FormAnimalShelterList formAnimalShelterList = new FormAnimalShelterList();
            Response.Redirect("FormAnimalShelterList.aspx");
        }

        protected void buttonCreateTable_Click(object sender, EventArgs e)
        {
            var createTableManager = new CreateTableManager();
            createTableManager.CreateAnimalTable();
            labelCreateTableMessage.Text = "Success";
            buttonCreateTable.Enabled = false;
        }
    }
}