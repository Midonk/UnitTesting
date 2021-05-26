using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListSystem
{
    /// <summary>
    /// Avannt de commencer, il peut être judicieux de consulter la documentation C# sur Linq
    /// </summary>
    /// 
    public class ListClass
    {
        ///Bonjour à toi, jeune apprenti. Avant de commencer, j'ai besoin que tu me fournisse deux données. J'ai besoin de la date du jour (en format string mmjjaa)
        ///ainsi que l'heure de début de la formation en format string hhmm.
        ///
        public List<string> TellMeThat()
        {

            
            return null;
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
        /// Revenons en à Unity. Une scène comprend plusieurs objets autout d'un point centre. Il faut renvoyer une liste des objets se trouvant à moins de 15 mètres
        /// de ce point central
        /// 

        public List<PointObject> AroundTheCenter(PointObject center, List<PointObject> objects)
        {
            return null;
        }












        /// <summary>
        /// Dans la  liste précédente, il existe plusieurs types d'objets. Nous ne souhaitons garder que les objets qui ont le tag enemy.
        /// </summary>
        /// 
        public List<PointObject> FilterTheList(List<PointObject> list)
        {

            return list;
        }





        /// <summary>
        /// Rhaaaa. Le stagiaire ne fait que des bétises et au lieu de mettre a jour la liste de produits, il en a créé deux autres ce qui crée plein de doublons.
        /// Aide moi a fusionner tout cà afin qu'il n'y ait plus qu'une liste mais sans les doublons
        /// </summary>
        /// 
        public List<Product> MergeTheLists(List<Product> list1, List<Product> list2, List<Product> list3)
        {

            return new List<Product>();
        }




        
        /// Pour en revenir à la liste de la formation, j'aurais besoin qu'elle soit triée, mais par rapport au prénom de la personne.
        
        public List<Person> SortTheClassRoomList(List<Person> list)
        {

            return list;
        }


        /// <summary>
        /// Enfin, un doublon s'était glissé dans la liste du Troisième exercice, renvoyez moi l'objet person, ainsi que le nombre d'occurences.
        /// </summary>
        /// 
        public KeyValuePair<Person,int> CheckTheDuplicate(List<Person> list)
        {

            return new KeyValuePair<Person, int>();
        }















        

    }

    

}
