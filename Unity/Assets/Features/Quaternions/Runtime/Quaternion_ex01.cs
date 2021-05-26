using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestSystem
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

        /*
        *  Appliquez une rotation 30° à une pomme sur son axe Y
        */

        public Quaternion ApplyRotationOnY(Quaternion value)
        {
            // attendu
            //return Quaternion.Euler(0, 30, 0);
            return value;
        }

        /*
         *  créer l'inverse d'une rotation de 30°
         */

        public Quaternion ApplyInverseRotationOf30(Quaternion value)
        {
            // attendu :
            // return Quaternion.Inverse(Quaternion.Euler(0, 30, 0));
            return value;
        }

        /*
         * revenez à la rotation de 30 avec un écart maximum de 1°
         */

        public Quaternion ComeBackFromNegative30ToRotation30(Quaternion value)
        {
            // attendu :
            // return Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
            //                                Quaternion.Euler(0, 30, 0),
            //                                1);

            return value;
        }

        #endregion Main
    }
}