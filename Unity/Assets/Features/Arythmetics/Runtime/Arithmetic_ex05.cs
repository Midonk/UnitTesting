using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arithmetics
{
    public class Arithmetic_ex05
    {
        public float m_waveVariationScale;

        #region Constructor
        public Arithmetic_ex05(float wavevariationscale)
        {
            m_waveVariationScale = wavevariationscale;
        }

        #endregion


        // Ce n'est point fini les amis, � pr�sent, Cherif veut absolument impl�menter un moyen de faire grossir
        // ou diminuer la largeur des vagues selon un temps �coul�, avec la valeur de grandeur de d�but et de fin.
        // Sachant que la grandeur minimale est de 1m et 50cm.

        public float CalculateWaves(float value)
        {
            return 0;
        }
    }
}