using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Avant de pouvoir tourner le prochain relais vous devez
/// communiquer un code de sécurité à l'IA !
///
/// [level Design]
///     source de photon
///     IA du satellites
///
/// [énigme]
/// Pour obtenir votre code de sécurité
/// faites le produit de la rotation de l'énigme 1 avec l'énigme 2
/// et donnez le reste en tant que code de sécurité
/// </summary>

namespace QuaternionTestSystem
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
            //return Quaternion.Dot(Quaternion.Euler(0, 30, 0), Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));

            // attendu :
            //return 9998477;
            return value;
        }

        #endregion Main
    }
}