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


        // Ce n'est point fini les amis, à présent, Cherif veut absolument implémenter un moyen de faire grossir
        // ou diminuer la largeur des vagues selon un temps écoulé entre 0 et 1, avec la valeur de grandeur de début et de fin.
        // Saachant que la grandeur minimale est de 1m et 50cm.

        public float CalculateWaves(float value)
        {
            var variation = Mathf.Lerp(1.5f, m_waveVariationScale, Time.time);
            return variation;
        }
    }
}