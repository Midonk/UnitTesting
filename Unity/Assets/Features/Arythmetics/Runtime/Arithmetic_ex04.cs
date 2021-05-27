using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arithmetics
{    public class Arithmetic_ex04
    {
        public float m_waveLength;

        #region Constructor
        public Arithmetic_ex04(float wavelength)
        {
            m_waveLength = wavelength;
        }

        #endregion


        // Et là, Cherif décide d'intégrer un timer qui inclus les arrivées de vagues afin qu'elles se succèdent.
        // Il pense au premier jeu vidéo afin d'implémenter son calcul de math dans un script,
        // du même nom qu'un sport avec des petites balles blanches et deux raquettes qu'il pratiquait lorsqu'il pleuvait
        // et qu'il ne pouvait pas aller au tennis.
        // Il connait la longueur des vagues avant qu'elle ne retombent et qu'une nouvelle apparaisse derrière
        // puisque leur longueur est de 1m et 50cm.
        // Il sait aussi que le temps qui sépare chaque vague est de 2 secondes
        public float CalculateWaves(float value)
        {
            return 0;
        }
    }
}