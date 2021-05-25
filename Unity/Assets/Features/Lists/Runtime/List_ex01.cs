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
            
            return "";
        }







        /// Bien, voyons un peu plus grand maintenant. Et changeons completement de sujet. Quels sont les modules de la formation qui durent le moins longtemps.
        /// Disons, moins de 14 jours et qui est à propos de Unity.

        public List<Module> CheckModules(List<Module> modules)
        {
            return null;
        }





        /// 
        /// Revenons en à Unity. Une scènbe comprend plusieurs objets autout d'un point centre. Il faut renvoyer une liste des objets se trouvant à moins de 10 mètres
        /// de ce point central
        /// 

        public List<PointObject> AroundTheCenter(PointObject center, List<PointObject> objects)
        {
            return null;
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

    public struct Module
    {
        public Module(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public string Name;
        public int Length;
    }

    public struct PointObject
    {
        public PointObject(string name, Vector3 pos)
        {
            Name = name;
            Pos = pos;
        }

        public string Name;
        public Vector3 Pos;
    }

}
