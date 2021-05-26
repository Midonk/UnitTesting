using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
namespace TestSystem
{
    public class Quaternion_ex06
    {
        #region Exposed

        public Quaternion m_lerp;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex06(Quaternion _lerp)
        {
            m_lerp = _lerp;
        }

        #endregion Constructor

        #region Main

        public Quaternion GetTheLerp(Quaternion value)
        {
            // calcul de la réponse
            value = Quaternion.Lerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(26, 5, 21), 1);

            //return value;
            return value;
        }

        #endregion Main
    }
}