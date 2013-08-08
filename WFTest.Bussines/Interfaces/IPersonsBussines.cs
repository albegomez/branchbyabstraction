using BranchAbstraction.Data;
using System;
using System.Collections.Generic;
namespace BranchAbstraction.Bussines
{
    public interface IPersonsBussines
    {
        List<Person> GetPersonByPersonType(string personType);
        List<Person> GetPersons();
    }
}
