using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex06
    {
        #region Public
        public float m_radius;
        public static Vector3 m_myPosition = new Vector3(0.0f, 0.0f, 0.0f);
        public static Vector3 m_otherPosition = new Vector3(1.0f, 1.0f, 1.0f);

        #endregion


        #region Constructors
        public Geometry_ex06(float radius)
        {
            m_radius = radius;
        }
        #endregion


        #region Main

        /// La guerre des carrés c'est terminée il y a de ça 100 ans.
        /// La guerre des cubes qui suivit l'évolution des carré en cubes c'est terminée il y a 25 ans.
        /// Désormais, ce sont les sphères qui se font la guerre pour le territoire.
        /// Detecte les collisions dans ce nouveau monde en 3d
        public bool IsCollidingWith(Geometry_ex06 other)
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
