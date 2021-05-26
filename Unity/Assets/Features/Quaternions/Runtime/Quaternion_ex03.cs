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
/// revenez à la rotation de 30 avec un écart maximum de 1°
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
            //réponse attendue :
            // return Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
            //                                Quaternion.Euler(0, 30, 0),
            //                                1);

            return value;
        }

        #endregion Main
    }
}