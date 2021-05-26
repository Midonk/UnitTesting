using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex03
    {
        #region Public
        public Vector2Int m_position;
        public Vector2Int m_destination;

        #endregion


        #region Constructors
        public Geometry_ex03(Vector2Int position, Vector2Int destination)
        {
            m_position = position;
            m_destination = destination;
        }
        #endregion


        #region Main

        /// Terra est un personnage de J-RPG rétro, condamnée à se déplacée dans une grille horizontalement ou verticalement
        /// Aide la à briser la matrice en calculant la distance qu'elle va parcourir si elle va en ligne droite vers sa destination.
        public float ComputeDistance()
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
