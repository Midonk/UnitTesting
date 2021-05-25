using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{ 
    public class Array_ex01
    {
		#region Publics

		public int[] m_intArray;

		#endregion


		#region Constructor

		public Array_ex01(int[] array)
		{
			m_intArray = array;
		}

		#endregion


		#region Main

		/// Nos renseignements ont obtenu plusieurs points d'int�r�ts sur le terrain
		/// Nos ressources sont limit�es et nous ne pourrons qu'en capturer un seul
		/// D�terminer la valeur la plus haute contenue parmis ces points
		public int GetHighestStrategicalValuePoint(int[] interestPoints)
		{
			return 2147483647;
		}

		#endregion
	}
}