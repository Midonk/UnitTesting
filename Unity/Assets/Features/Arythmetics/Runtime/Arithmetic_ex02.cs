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


        // Cherif se balades � la plage, et il se met � vouloir calculer la forme des vagues.
        // Oui, car il aime faire des calculs complexes afin de les int�grer dans ses jeux.
        // Et il se rend compte que gr�ce � la force du vent, toutes les vagues se ressemblent selon la lune,
        // et aujourd'hui la hauteur des vagues sont d' 1 m et 20 cm et elles s'�crasent apr�s 1 m et 50 cm.
        // Il a d�j� calcul� la somme des carr�s des cot�s et a d�cid� de commencer par calculer l'hypoth�nuse.
        public float CalculateHypothesis(float value)
        {
            return 0;
        }
    }
}