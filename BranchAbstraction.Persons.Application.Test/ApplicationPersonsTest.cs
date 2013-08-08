using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BranchAbstraction.Bussines;
using BranchAbstraction.Data;

namespace BranchAbstraction.Persons.Application.Test
{
    [TestClass]
    public class ApplicationPersonsTest
    {
        /// <summary>
        /// Testeamos el obtener todas las personas
        /// </summary>
        [TestMethod]
        public void Application_Persons_ObtenerTodoslasPersonasOld()
        {
            IPersonsBussines personsBussines = new PersonsBussines();
            List<Person> personas = personsBussines.GetPersons(); 
            Assert.AreEqual("Ken", personas[0].FirstName);

        }

        [TestMethod]
        public void Application_Persons_ObtenerTodoslasPersonasVaronesOld()
        {
            IPersonsBussines personsBussines = new PersonsBussines();
            List<Person> personas = personsBussines.GetPersonByPersonType("EM"); 
            Assert.AreEqual("Ken", personas[0].FirstName);
        }
    }
}
