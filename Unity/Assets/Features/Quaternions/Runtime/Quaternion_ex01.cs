using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// [Infos]
/// Vous �tes le technicien de maintenance de la cha�ne de satellite
/// d'Elon Musk celle-ci relie la terre � la plan�te Mars.
///
/// A la suite de la r�cente temp�te solaire, vous devez r�aligner les diff�rents
/// mirroirs pour r�tablir la liaison de particules photon.
///
/// Le canon � photon se trouve en orbite terrestre sur ISS,
/// vous leur demander via une simple liaison radio de corriger l'axe
/// du canon pour viser le premier satellite relais
///
/// [Level Design]
///     canon � photon
///     satellite
///     ISS
///     relais � photon
///
/// [Task]
/// Demandez aux ing�nieur sur l'ISS de tourner le canon de 30� sur son axe vertical.
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
            //r�ponse attendue :
            //return Quaternion.Euler(0, 30, 0);
            return value;
        }

        #endregion Main
    }
}