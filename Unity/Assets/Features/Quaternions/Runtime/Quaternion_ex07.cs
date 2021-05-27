using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// La caméra qui vous permet de voir l'etat du miroir à bougée
/// Il vous faut avant de bouger le miroir vérifier l'état de celui-ci
///
/// [level Design]
///     Caméra
///     Relais
///     Miroir
///
/// [énigme]
/// Les directions à données sont en bas et à gauche
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