using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Par chance le dernier Satellite en orbite marsienne �tait en place
/// F�licitation !
/// Votre derni�re tache de la journ�e est de faire d�coller et avancer
/// Ingenuity
///
/// [Task]
/// Demandez � l'ia d'ordonner � Ingeuity de d�coller et partir vers l'avant !
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