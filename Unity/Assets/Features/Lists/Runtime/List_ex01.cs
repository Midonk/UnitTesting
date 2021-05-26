using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListSystem
{
    /// <summary>
    /// Avannt de commencer, il peut �tre judicieux de consulter la documentation C# sur Linq
    /// </summary>
    /// 
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
        /// Revenons en � Unity. Une sc�ne comprend plusieurs objets autout d'un point centre. Il faut renvoyer une liste des objets se trouvant � moins de 15 m�tres
        /// de ce point central
        /// 

        public List<PointObject> AroundTheCenter(PointObject center, List<PointObject> objects)
        {
            return null;
        }












        /// <summary>
        /// Dans la  liste pr�c�dente, il existe plusieurs types d'objets. Nous ne souhaitons garder que les objets qui ont le tag enemy.
        /// </summary>
        /// 
        public List<PointObject> FilterTheList(List<PointObject> list)
        {

            return list;
        }





        /// <summary>
        /// Rhaaaa. Le stagiaire ne fait que des b�tises et au lieu de mettre a jour la liste de produits, il en a cr�� deux autres ce qui cr�e plein de doublons.
        /// Aide moi a fusionner tout c� afin qu'il n'y ait plus qu'une liste mais sans les doublons
        /// </summary>
        /// 
        public List<Product> MergeTheLists(List<Product> list1, List<Product> list2, List<Product> list3)
        {

            return new List<Product>();
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
        public PointObject(string name, Vector3 pos, string tag)
        {
            Name = name;
            Pos = pos;
            Tag = tag;
        }

        public string Name;
        public Vector3 Pos;
        public string Tag;
    }

    public struct Product
    {
        public Product(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string Name;
        public string Category;
        public float Price;

    }

}
