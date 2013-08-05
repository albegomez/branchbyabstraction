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
            List<Person> personsEM = new PersonsBussines().GetPersonByPersonType("EM");
            dataGridView1.DataSource = personsEM;           

        }
    }
}
