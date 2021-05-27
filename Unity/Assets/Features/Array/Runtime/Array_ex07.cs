using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class Array_ex07
    {
        #region Publics

        public string[] m_carrierInventory;

        #endregion


        #region Constructor

        public Array_ex07(string[] inventory)
        {
            m_carrierInventory = inventory;
        }

        #endregion


        #region Main

        /// Notre extracteur de ressources est opérationnel et nous pouvons maintenant ravitailler notre base
        /// Problème, nous avons extraits toutes sortes de ressources différentes
        /// Trier la ressource ciblée et stockez-la dans l'inventaire du transporteur
        /// Attention notre transporteur à un inventaire limité
        public string[] RessourcesForCarrier(string[] ressources, string targetRessource)
        {
            return m_carrierInventory;
        }

        #endregion
    }
}