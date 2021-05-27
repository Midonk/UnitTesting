using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// La plan�te mars est toute proche
/// La cam�ra qui vous permet de voir celle-ci � boug�e
/// Il vous faut la r�gl�e avant de pouvoir voir la plan�te rouge.
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
            // r�ponse attendue :
            //return Quaternion.LookRotation(Vector3.down, Vector3.left);

            return value;
        }

        #endregion Main
    }
}