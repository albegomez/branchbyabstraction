using BranchAbstraction.Data;
using System;
using System.Collections.Generic;
namespace BranchAbstraction.Persons.Application
{
    public interface IPersonsAplication
    {
        List<Person> GetPersonByPersonType(string personType);
       List<Person> GetPersons();
    }
}
