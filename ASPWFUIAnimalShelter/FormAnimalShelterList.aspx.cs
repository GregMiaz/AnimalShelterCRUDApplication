using SOCAnimalShelterDataMigration.Controllers;
using SOCAnimalShelterDataMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWFUIAnimalShelter
{
    public partial class FormAnimalShelterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var readController = new ReadController();
                gridViewAnimals.DataSource = readController.ReadAnimals();
                gridViewAnimals.DataBind();
            }
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormAnimalShelterAddNew.aspx");
        }

        protected void gridViewAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gridViewRow = gridViewAnimals.SelectedRow;
            labelDetails.Text = "Animal details: Name: ";
            labelDetails.Text += gridViewRow.Cells[0].Text;
            labelDetails.Text += ", Species: ";
            labelDetails.Text += gridViewRow.Cells[1].Text;
            labelDeleteResult.Text = "";
        }

        protected void gridViewAnimals_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var animalId = gridViewAnimals.DataKeys[e.RowIndex].Value;
            int id = (int)animalId;
            var deleteController = new DeleteController();
            var deleteResult = deleteController.DeleteAnimal(id);
            var readController = new ReadController();
            gridViewAnimals.DataSource = readController.ReadAnimals();
            gridViewAnimals.DataBind();
            if (deleteResult==1)
            {
                labelDeleteResult.Text = "You successfully deleted animal from database.";
            }
            else
            {
                labelDeleteResult.Text = "Delete operation failed.";
            }           
        }
    }
}