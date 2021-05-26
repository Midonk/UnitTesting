using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arithmetics
{
    public class Arithmetic_ex05
    {
        public Vector2 m_waveChangeScale;

        #region Constructor
        public Arithmetic_ex05(Vector2 wavechangescale)
        {
            m_waveChangeScale = wavechangescale;
        }

        #endregion


        // Ce n'est point fini les amis, à présent, Cherif veut absolument implémenter un moment de faire grossir
        // ou diminuer la taille des vagues selon le temps écoulé entre 0 et 1, avec une valeur de début et de fin.


        public float CalculateWaves(float value)
        {
            return 0;
        }
    }
}