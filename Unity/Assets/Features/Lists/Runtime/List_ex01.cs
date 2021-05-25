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
        public Person WhoIsThatPerson(List<Person> classroomList)
        {
            return new Person() ;
        }







        /// J'ai entendu une drole d'histoire � propos de cette personne. Mais attends, qui �tait-ce d�j� ? Zut j'ai la m�moire courte. 
        /// Mais je sais que l'on peut trouver le nom de son pire enemi. 
        /// 

        public string ThatEnemy(List<Person> classroomList)
        {
            
            return "";
        }







        /// Bien, voyons un peu plus grand maintenant. Et changeons completement de sujet. Quels sont les modules de la formation qui durent le moins longtemps.
        /// Disons, moins de 14 jours et qui est � propos de Unity.

        public List<Module> CheckModules(List<Module> modules)
        {
            return null;
        }





        /// 
        /// Revenons en � Unity. Une sc�nbe comprend plusieurs objets autout d'un point centre. Il faut renvoyer une liste des objets se trouvant � moins de 10 m�tres
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
