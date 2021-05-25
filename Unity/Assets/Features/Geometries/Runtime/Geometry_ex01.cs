using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex01
    {
        #region Public
        public float m_width;
        public float m_lenght;

        #endregion


        #region Constructors
        public Geometry_ex01(float width, float length)
        {
            m_lenght = length;
            m_width = width;
        }
        #endregion


        #region Main

        ///Sur base de la longueur et de la largeur du rectangle, dis si celui-ci est un carré
        public bool IsSquare()
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
