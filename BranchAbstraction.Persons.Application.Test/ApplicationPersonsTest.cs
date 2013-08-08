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
        public static void inicialiceTest()
        {
            IPersonsBussines personsBussines = new NewPersonsBussines();
            List<Person> personas = personsBussines.GetPersonByPersonType("EM");
            var nombre = personas[0].FirstName;
        }
        /// <summary>
        /// Testeamos el obtener todas las personas
        /// </summary>
       [TestCategory("Application"), TestMethod]
        public void ObtenerTodoslasPersonasOld()
        {
            IPersonsBussines personsBussines = new PersonsBussines();
            List<Person> personas = personsBussines.GetPersons(); 
            Assert.AreEqual("Ken", personas[0].FirstName);
        }

       [TestCategory("Application"), TestMethod]
        public void ObtenerTodoslasPersonasVaronesOld()
        {
            IPersonsBussines personsBussines = new PersonsBussines();
            List<Person> personas = personsBussines.GetPersonByPersonType("EM"); 
            Assert.AreEqual("Ken", personas[0].FirstName);
        }

       [TestCategory("Application"), TestMethod]
       public void ObtenerTodoslasPersonasNew()
       {
           IPersonsBussines personsBussines = new NewPersonsBussines();
           List<Person> personas = personsBussines.GetPersons();
           Assert.AreEqual("Ken", personas[0].FirstName);

       }

       [TestCategory("Application"), TestMethod]
       public void ObtenerTodoslasPersonasVaronesNew()
       {
           IPersonsBussines personsBussines = new NewPersonsBussines();
           List<Person> personas = personsBussines.GetPersonByPersonType("EM");
           Assert.AreEqual("Ken", personas[0].FirstName);
       }
    }
}
