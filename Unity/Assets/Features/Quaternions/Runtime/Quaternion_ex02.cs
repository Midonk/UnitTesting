using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Bien, vous venez de relier l'ISS au premier satellite et
/// vous pouvez maintenant lui envoyer des commandes via le flux de particules photon
/// vous devez maintenant tourner orienter ce relais.
///
/// [outils]
///     canon à photon
///     satellites
///     relais à photon
///
/// [énigme]
/// Il vous faut envoyer une commande sous forme de Quaternion en prenant l'inverse de la premiere commande pour que le miroir du satellite puisse être orienter dans le bon sens.
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