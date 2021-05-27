using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Avant de pouvoir tourner le prochain relais vous devez
/// communiquer un code de s�curit� � l'IA !
///
/// [level Design]
///     source de photon
///     IA du satellites
///
/// [�nigme]
/// Pour obtenir votre code de s�curit�
/// faites le produit de la rotation de l'�nigme 1 avec l'�nigme 2
/// et donnez le reste en tant que code de s�curit�
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