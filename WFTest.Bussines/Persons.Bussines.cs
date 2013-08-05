using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchAbstraction.Data;
using System.Data.Linq;

namespace BranchAbstraction.Bussines
{
    public class PersonsBussines
    {
        public List<Person> GetPersons()
        {
            using (AdventureWorks2012Context aworkContext = new AdventureWorks2012Context())
            {
                return aworkContext.People.ToList();
            }
        }
        public List<Person> GetPersonByPersonType(string personType)
        {
            return GetPersons().Where(person => person.PersonType == personType).ToList(); 
        }
    }
}
