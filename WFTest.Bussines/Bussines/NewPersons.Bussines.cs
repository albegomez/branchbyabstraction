using BranchAbstraction.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Linq;

namespace BranchAbstraction.Bussines
{
    public class NewPersonsBussines:IPersonsBussines
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

            using (AdventureWorks2012Context aworkContext = new AdventureWorks2012Context())
            {
                var personasVarones = from persons in aworkContext.People
                                      where persons.PersonType == personType
                                      select persons;
                return personasVarones.ToList(); 
            }
          
        }
    }
}
