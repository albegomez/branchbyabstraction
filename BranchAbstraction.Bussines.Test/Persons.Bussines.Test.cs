using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchAbstraction.Data;
using System.Collections.Generic;

namespace BranchAbstraction.Bussines.Test
{
    [TestClass]
    public class Persons
    {
        [TestMethod]
        public void ObtenerTodoslasPersonas()
        {
            List<Person> personas = new PersonsBussines().GetPersons();
            Assert.AreEqual("Ken", personas[0].FirstName);

        }
        [TestMethod]
        public void ObtenerTodoslasPersonasVarones()
        {
            List<Person> personas = new PersonsBussines().GetPersonByPersonType("EM");
            Assert.AreEqual("Ken", personas[0].FirstName);

        }

    }
}
