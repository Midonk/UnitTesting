using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex05
    {
        #region Public
        public float m_hitBoxHeight;

        public static Vector2 m_myPosition = new Vector2(0.0f, 0.0f);
        public static Vector2 m_otherPosition = new Vector2(1.0f, 0.0f);

        #endregion


        #region Constructors
        public Geometry_ex05(float hitBoxHeight)
        {
            m_hitBoxHeight = hitBoxHeight;
        }
        #endregion


        #region Main

        /// La guerre des carrés a commencé.
        /// Une collision à lieu si leur 2 hitbox se superposent.
        /// On considère que leur position correspond au centre de la position. 
        public bool IsCollidingWith(Geometry_ex05 other)
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
