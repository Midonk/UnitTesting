using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arithmetics
{    public class Arithmetic_ex02
    {
        public float m_squaredSidesAmount;

        #region Constructor
        public Arithmetic_ex02(float squaredsidesamount)
        {
            m_squaredSidesAmount = squaredsidesamount;
        }

        #endregion


        // Cherif se balades à la plage, et il se met à vouloir calculer la forme des vagues.
        // Oui, car il aime faire des calculs complexes afin de les intégrer dans ses jeux.
        // Et il se rend compte que grâce à la force du vent, toutes les vagues se ressemblent selon la lune,
        // et aujourd'hui la hauteur des vagues sont d' 1 m et 20 cm et elles s'écrasent après 1 m et 50 cm.
        // Il a déjà calculé la somme des carrés des cotés et a décidé de commencer par calculer l'hypothénuse.
        public float CalculateHypothesis(float value)
        {
            return 0;
        }
    }
}