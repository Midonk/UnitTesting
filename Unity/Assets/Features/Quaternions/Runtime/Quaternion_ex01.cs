using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// bonjour
///
/// [level Design]
/// mise en scene
/// porte
/// crane
///
/// [�nigme]
/// il est �crit tournez de 30� le crane sur son axe vertical
/// </summary>

namespace TestSystem
{
    public class Quaternion_ex01
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex01(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion ApplyRotationOnY(Quaternion value)
        {
            //r�ponse attendue :
            //return Quaternion.Euler(0, 30, 0);
            return value;
        }

        #endregion Main
    }
}