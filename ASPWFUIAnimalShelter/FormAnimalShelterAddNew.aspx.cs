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
    public partial class FormAnimalShelterAddNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            var newAnimal = new Animal()
            {
                Name = textBoxName.Text,
                Species = textBoxSpecies.Text,
                Weight = Convert.ToInt32(textBoxWeight.Text),
                DateOfBirth = Convert.ToDateTime(textBoxDateOfBirth.Text)
            };

            AddController addController = new AddController();
            addController.AddAnimal(newAnimal);
            Response.Redirect("FormAnimalShelterList.aspx");
        }
    }
}