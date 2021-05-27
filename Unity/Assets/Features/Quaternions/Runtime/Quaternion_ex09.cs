using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Le prochain satellite est américain !
/// Lorsque vous parlez discutez du satellite avec l'IA
/// Elle vous parle de liberté et indépendance !
///
/// [enigme]
/// Lorsque vous discutez du satellite avec l'IA
/// Elle vous parle de liberté et indépendance !
///
/// </summary>

namespace QuaternionTestSystem
{
    public class Quaternion_ex09
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex09(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion IndependanceDay(Quaternion value)
        {
            return value;
        }

        #endregion Main
    }
}