using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex05
    {
        #region Public
        public float m_hitBoxHeight;

        #endregion


        #region Constructors
        public Geometry_ex05(float hitBoxHeight)
        {
            m_hitBoxHeight = hitBoxHeight;
        }
        #endregion


        #region Main

        /// La guerre des carrés a commencé.
        /// Détecte la collision entre 2 carrés situés en (0; 0) et (1; 0)
        /// Une collision à lieu si leur 2 hitbox se superposent.
        /// On considère que leur position correspond au centre de la position. 
        public bool IsCollidingWith(Geometry_ex05 other)
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
