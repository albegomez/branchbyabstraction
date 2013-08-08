using BranchAbstraction.Bussines;
using BranchAbstraction.Persons.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAbstraction.Presentation.Application
{
    public class ApplicationCreator
    {
        ApplicationCreator() { }

        /// <summary>
        /// Creamos esta subclase para hacer la carga lazy and Thread Safe.
        /// </summary>
        class AplicationCreatorSingleton 
        {
            internal static readonly ApplicationCreator instance = new ApplicationCreator(); 
        }

        public static ApplicationCreator Instance
        {
           get{
               return AplicationCreatorSingleton.instance;
           }
        }


        /// <summary>
        /// Metodo que crea las intancias del serivio de aplication de personas, centralizamos la creacion de instancias aqui.
        /// </summary>
        /// <returns></returns>
        public IPersonsAplication CreatePersonApplication()
        {
            IPersonsBussines oldPersonsBussines = new PersonsBussines();
            IPersonsAplication aplicationService = new PersonsAplication(oldPersonsBussines);
            return aplicationService;
        }
    }
}
