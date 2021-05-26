using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vector3Tests
{
    public class Vector3_ex07 : MonoBehaviour
    {
        /// <summary>
        /// Bon sang, ce foutu miroir me renvoi un reflet distordu.
        /// Je pense qu'en raprochant ma tete a une certaine vitesse, le reflet devrait etre correct.
        /// Il y a une note sur ce miroir : "interpolant de 1.0f suivit des initiales PRELS"
        /// </summary>
        public Vector3 Check07(Vector3 baseHeadPosition, Vector3 finalHeadPosition)
        {

            return new Vector3(0,0,0);
        }
    }
}