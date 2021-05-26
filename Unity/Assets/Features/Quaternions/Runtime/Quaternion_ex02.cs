using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// texte de mise en scene
///
/// [level Design]
/// mise en scene
/// porte
/// crane
///
/// [énigme]
/// vous devez faire la rotation inverse de 30°
/// </summary>

namespace TestSystem
{
    public class Quaternion_ex02
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex02(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion ApplyInverseRotationOf30(Quaternion value)
        {
            //réponse attendue :
            // return Quaternion.Inverse(Quaternion.Euler(0, 30, 0));
            return value;
        }

        #endregion Main
    }
}