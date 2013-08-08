using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchAbstraction.Data;
using System.Collections.Generic;

namespace BranchAbstraction.Bussines.Test
{
    [TestClass]
    public class Persons
    {
         [TestCategory("Bussines"),TestMethod]
        public void ObtenerTodoslasPersonas()
        {
            List<Person> personas = new PersonsBussines().GetPersons();
            Assert.AreEqual("Ken", personas[0].FirstName);

        }
        [TestCategory("Bussines"),TestMethod]
        public void ObtenerTodoslasPersonasVarones()
        {
            List<Person> personas = new PersonsBussines().GetPersonByPersonType("EM");
            Assert.AreEqual("Ken", personas[0].FirstName);

        }
        [TestCategory("Bussines"), TestMethod]
        public void ObtenerTodoslasPersonasNew()
        {
            List<Person> personas = new NewPersonsBussines().GetPersons();
            Assert.AreEqual("Ken", personas[0].FirstName);

        }
        [TestCategory("Bussines"), TestMethod]
        public void ObtenerTodoslasPersonasVaronesNew()
        {
            List<Person> personas = new NewPersonsBussines().GetPersonByPersonType("EM");
            Assert.AreEqual("Ken", personas[0].FirstName);

        }

    }
}
