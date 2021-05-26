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
/// vous voyez un crane qui regarde à gauche et décidez de le tourner vers la droite
/// </summary>

namespace TestSystem
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