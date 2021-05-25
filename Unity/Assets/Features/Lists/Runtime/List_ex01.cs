using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListSystem
{
    public class List_ex01
    {
        ///Bonjour à toi, jeune apprenti. Avant de commencer, j'ai besoin que tu me fournisse deux données. J'ai besoin de la date du jour (en format string mmjjaa)
        ///ainsi que l'heure de début de la formation en format string hhmm.
        ///
        public List<string> TellMeThat()
        {
            return null;
        }





        /// Bien, maintenant que j'ai ces données, J'ai un service à te demander. J'ai besoin de trier une liste que je te passe en paramètre. Peux-tu m'aider ? 

        public List<int> HelpMeToSort(List<int> listToSort)
        {
            return listToSort;
        }





        /// Formidable, la liste est bien trièe, mais malheureusement, on n'en aura pas besoin :grins:. Il me faudrait que tu m'aides à récupérer une donnée.
        /// Cette donnée est l'objet Person du formateur Unity actuel. 
        /// 
        public Person WhoIsThatPerson(List<Person> classroomList)
        {
            return new Person() ;
        }

        /// J'ai entendu une drole d'histoire à propos de cette personne. Mais attends, qui était-ce déjà ? Zut j'ai la mémoire courte. 
        /// Mais je sais que l'on peut trouver le nom de son pire enemi. 
        /// 

        public string ThatEnemy(List<Person> classroomList)
        {
            
            return classroomList.Find(x => x.FirstName == "Cherif").Enemy;
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
