using System;
using UnityEngine;

namespace Geometries.Runtime
{
    public class Geometry_ex04
    {
        #region Public
        public float m_boxHeight;

        #endregion


        #region Constructors
        public Geometry_ex04(float boxHeight)
        {
            m_boxHeight = boxHeight;
        }
        #endregion


        #region Main

        /// Le docteur Néo Cortex a prévu un plan machiavélique pour tuer son ennemi marsupial.
        /// Il a créé des caisses à wumpa doublées de Nitro.
        /// Aide Crash à identifier les bonnes caisses sur base de la surface totale des 6 faces.
        /// Renvoie lui la surface totale des caisses, il devrait pouvoir faire le reste du boulot WOAH!
        public float ComputeSurface()
        {
            throw new NotImplementedException("Au boulot fainéant.");
        }
        #endregion
    }
}
