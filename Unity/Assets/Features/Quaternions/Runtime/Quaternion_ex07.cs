using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// La planète mars est toute proche
/// La caméra qui vous permet de voir celle-ci à bougée
/// Il vous faut la réglée avant de pouvoir voir la planète rouge.
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
            // réponse attendue :
            //return Quaternion.LookRotation(Vector3.down, Vector3.left);

            return value;
        }

        #endregion Main
    }
}