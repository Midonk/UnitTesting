using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex07
    {
        #region Public
        public float m_bodyRadius;
        public float m_headRadius;

        #endregion


        #region Constructors
        public Geometry_ex07(float _bodyRadius, float _headRadius)
        {
            m_bodyRadius = _bodyRadius;
            m_headRadius = _headRadius;
        }
        #endregion


        #region Main

        /// Un Lalafel est une sorte de petit patate proche de la mandragore, un cri terrifiant.
        /// Il pourrait se résumer en deux sphères agaçantes.
        /// Calcule le volume occupé par un lalafel sur base de ces deux sphères. 
        public float LalafelVolume()
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
