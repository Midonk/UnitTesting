using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// texte de mise en scene
///
/// [level Design]
/// mise en scene
/// porte
/// satellites
///
/// [énigme]
/// faites le produit de la rotation de l'énigme 1 avec l'énigme 2
/// et donnez le reste
/// </summary>

namespace TestSystem
{
    public class Quaternion_ex05
    {
        #region Exposed

        public float m_product;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex05(float _product)
        {
            m_product = _product;
        }

        #endregion Constructor

        #region Main

        public float ProductBetween1and2(float value)
        {
            //Debug.Log($"<color=orange>{Quaternion.Dot(Quaternion.Euler(0, 1, 0), Quaternion.Euler(0, 3, 0))}</color>");

            //return Quaternion.Dot(Quaternion.Euler(0, 30, 0), Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));
            Quaternion.

            // attendu :
            //return 9998477;
            return value;
        }

        #endregion Main
    }
}