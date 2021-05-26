using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex02
    {
        #region Public
        public float m_handWidth;

        #endregion


        #region Constructors
        public Geometry_ex02(float handWidth)
        {
            m_handWidth = handWidth;
        }
        #endregion


        #region Main

        /// Calcule le périmètre d'un fragment de la triforce 
        /// Sachant que la base de la triforce fait 2 tier de la largeur de main de son porteur
        /// Et que ce fragment est un triangle équilatéral.
        public float ComputePerimeter()
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        
        #endregion
    }
}
