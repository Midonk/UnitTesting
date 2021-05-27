using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Vous êtes le technicien de maintenance de la chaîne de satellite
/// d'Elon Musk celle-ci relie la terre à la planète Mars.
///
/// A la suite de la récente tempête solaire, vous devez réaligner les différents
/// mirroirs pour rétablir la liaison de particules photon.
///
/// Le canon à photon se trouve en orbite terrestre sur ISS,
/// vous leur demander via une simple liaison radio de corriger l'axe
/// du canon pour viser le premier satellite relais
///
/// [Level Design]
///     canon à photon
///     satellite
///     ISS
///     relais à photon
///
/// [Task]
/// Demandez aux ingénieur sur l'ISS de tourner le canon de 30° sur son axe vertical.
/// En leur envoyant votre demande sous forme d'un Quaternion.
///
/// </summary>

namespace QuaternionTestSystem
{
    public class Quaternion_ex01
    {
        #region Exposed

        public Quaternion m_rotation;

        #endregion Exposed

        #region Constructor

        public Quaternion_ex01(Quaternion _rotation)
        {
            m_rotation = _rotation;
        }

        #endregion Constructor

        #region Main

        public Quaternion ApplyRotationOnY(Quaternion value)
        {
            //réponse attendue :
            //return Quaternion.Euler(0, 30, 0);
            return value;
        }

        #endregion Main
    }
}