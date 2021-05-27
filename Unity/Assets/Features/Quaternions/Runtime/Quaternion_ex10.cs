using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Par chance le dernier Satellite en orbite marsienne était en place
/// Félicitation !
/// Votre dernière tache de la journée est de faire décoller et avancer
/// Ingenuity
///
/// [Task]
/// Demandez à l'ia d'ordonner à Ingeuity de décoller et partir vers l'avant !
///
/// </summary>
namespace QuaternionTestSystem
{
    public class Quaternion_ex10
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex10(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion LetsFly(Quaternion value)
        {
            return value;
        }

        #endregion Main
    }
}