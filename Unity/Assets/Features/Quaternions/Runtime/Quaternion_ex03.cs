using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Le satellite suivant est carr�ment retourn� sur son axe vertical !
/// il faut le faire rouler sur lui m�me.
///
/// [Level Design]
///     source de photon
///     satellites
///     relais � photon
///
/// [�nigme]
/// Le relais est dans la rotation -30� sur son axe vertical vous devez revenir � la rotation de 30� avec un �cart maximum de 1� d'erreur !
/// </summary>

namespace TestSystem
{
    public class Quaternion_ex03
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex03(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion ComeBackFromNegative30ToRotation30(Quaternion value)
        {
            //r�ponse attendue :
            // return Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
            //                                Quaternion.Euler(0, 30, 0),
            //                                1);

            return value;
        }

        #endregion Main
    }
}