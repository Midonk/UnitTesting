using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// vous devez tourner horizontalement ce relais pour qu'il puisse envoyer la lumi�re vous souhaitez
///
/// [Level Design]
///     source de photon
///     satellites
///     relais � photon
///
/// [�nigme]
/// le relais est orient� compl�tement � gauche et vous d�cider de l'orienter compl�tement � droite
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
            //r�ponse attendue :
            //return Quaternion.FromToRotation(Vector3.left, Vector3.right);
            return value;
        }

        #endregion Main
    }
}