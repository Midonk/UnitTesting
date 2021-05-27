using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// L'IA vous souhaite la bienvenue sur ce relais
/// et souhaite que vous l'aidiez car son relais est tourn� dans le
/// mauvais sens pour pouvoir r�activer le flux de photon
///
/// [level Design]
///     IA du relais satellite
///
/// [�nigme]
/// la premiere rotation co�ncide avec la date de d�but de formation
/// et la rotation voulue est la date du d�but de cr�ation de l'exercice
/// la vitesse est de 1
/// </summary>
namespace QuaternionTestSystem
{
    public class Quaternion_ex06
    {
        #region Exposed

        public Quaternion m_Slerp;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex06(Quaternion _Slerp)
        {
            m_Slerp = _Slerp;
        }

        #endregion Constructor

        #region Main

        public Quaternion GetTheSlerp(Quaternion value)
        {
            // calcul de la r�ponse
            //value = Quaternion.Slerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(27, 5, 21), 1);

            //return value;
            return value;
        }

        #endregion Main
    }
}