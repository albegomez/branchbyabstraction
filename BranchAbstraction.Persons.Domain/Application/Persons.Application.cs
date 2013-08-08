using BranchAbstraction.Bussines;
using BranchAbstraction.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAbstraction.Persons.Application
{

    /// <summary>
    /// Capa de abstraccion que nos da acceso al negocio.   
    /// </summary>
    public class PersonsAplication : IPersonsAplication
    {
           IPersonsBussines personsBussines;
        /// <summary>
        /// Creamos en el constructor la inyeccion para realizar el switch del negocio nuevo con el antiguo
        /// </summary>
        /// <param name="personsBussines"></param>
           public PersonsAplication(IPersonsBussines personsBussines)
           {
               this.personsBussines = personsBussines;
            }
            public List<Person> GetPersons()
            {
                return personsBussines.GetPersons(); 
            }
            public List<Person> GetPersonByPersonType(string personType)
            {
                return personsBussines.GetPersonByPersonType(personType); 
            }
    }
}
