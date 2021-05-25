using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListSystem
{
    public class List_ex01
    {
        ///Bonjour � toi, jeune apprenti. Avant de commencer, j'ai besoin que tu me fournisse deux donn�es. J'ai besoin de la date du jour (en format string mmjjaa)
        ///ainsi que l'heure de d�but de la formation en format string hhmm.
        ///
        public List<string> TellMeThat()
        {
            return null;
        }





        /// Bien, maintenant que j'ai ces donn�es, J'ai un service � te demander. J'ai besoin de trier une liste que je te passe en param�tre. Peux-tu m'aider ? 

        public List<int> HelpMeToSort(List<int> listToSort)
        {
            return listToSort;
        }





        /// Formidable, la liste est bien tri�e, mais malheureusement, on n'en aura pas besoin :grins:. Il me faudrait que tu m'aides � r�cup�rer une donn�e.
        /// Cette donn�e est l'objet Person du formateur Unity actuel. 
        /// 
        public Person Ex03(List<Person> classroomList)
        {
            return new Person() ;
        }


        public List_ex01()
        {

        }

    }

    public struct Person
    {
        public Person( string firstName, string lastName, string enemy)
        {
            FirstName = firstName;
            LastName = lastName;
            Enemy = enemy;
        }

        public string FirstName;
        public string LastName;
        public string Enemy;
    }
}
