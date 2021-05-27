using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// vous apercevez au loin la plan�te rouge
/// il vous faut g�olocaliser sur la station d'Elon Musk
/// gr�ce � la triangulation via 3 satellites !
///
/// le premier est plac� au dessus de la ville de Roswell
///
///
///
/// [Task]
/// Il faut donner � l'IA un Quaternion pour pouvoir bouger ce satellite
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

        public Quaternion TheCrashWasReal(Quaternion value)
        {
            return value;
        }

        #endregion Main
    }
}