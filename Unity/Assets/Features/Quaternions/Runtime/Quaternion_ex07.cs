using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// La cam�ra qui vous permet de voir l'etat du miroir � boug�e
/// Il vous faut avant de bouger le miroir v�rifier l'�tat de celui-ci
///
/// [level Design]
///     Cam�ra
///     Relais
///     Miroir
///
/// [�nigme]
/// Les directions � donn�es sont en bas et � gauche
/// </summary>
namespace QuaternionTestSystem
{
    public class Quaternion_ex07
    {
        #region Exposed

        public Quaternion m_LookRotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex07(Quaternion _LookRotation)
        {
            m_LookRotation = _LookRotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion ChangeLookRotation(Quaternion value)
        {
            Debug.Log($"<color=orange>{Quaternion.LookRotation(Vector3.down, Vector3.left)}</color>");
            return Quaternion.LookRotation(Vector3.down, Vector3.left);

            //return value;
        }

        #endregion Main
    }
}