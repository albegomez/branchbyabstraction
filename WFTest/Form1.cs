using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BranchAbstraction.Bussines;
using BranchAbstraction.Data;
using BranchAbstraction.Presentation.Application;
using BranchAbstraction.Persons.Application;

namespace BranchAbstraction.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonCargaHombres_Click(object sender, EventArgs e)
        {
            IPersonsAplication personAplication = ApplicationCreator.Instance.CreatePersonApplication();
            List<Person> personsEM = personAplication.GetPersonByPersonType("EM"); 
            dataGridView1.DataSource = personsEM;           

        }
    }
}
