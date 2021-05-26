using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// vous devez tourner horizontalement ce relais pour qu'il puisse envoyer la lumière vous souhaitez
///
/// [Level Design]
///     source de photon
///     satellites
///     relais à photon
///
/// [énigme]
/// le relais est orienté complètement à gauche et vous décider de l'orienter complètement à droite
/// </summary>

namespace QuaternionTestSystem
{
    public class Quaternion_ex04
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex04(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion TurnTheCrane(Quaternion value)
        {
            //réponse attendue :
            //return Quaternion.FromToRotation(Vector3.left, Vector3.right);
            return value;
        }

        #endregion Main
    }
}