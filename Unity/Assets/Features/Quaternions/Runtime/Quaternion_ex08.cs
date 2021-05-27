using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// vous apercevez au loin la planète rouge
/// il vous faut géolocaliser sur la station d'Elon Musk
/// grâce à la triangulation via 3 satellites !
///
///
///
/// [Task]
/// Il faut demander à l'IA d'entrer la date du crash de Roswell
/// pour connaître la rotation du premier satellite
///
/// </summary>

namespace QuaternionTestSystem
{
    public class Quaternion_ex08
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex08(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion TheTruthIsSomeWhereElse(Quaternion value)
        {
            return Quaternion.Euler(07, 08, 47);
            //return value;
        }

        #endregion Main
    }
}