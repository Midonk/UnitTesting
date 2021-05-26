using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
	public class Array_ex06
	{
		#region Main

		/// Inverser les index du tableau
		/// (Oui j'avais pas d'idée)
		public int[] RevertCode(int[] array)
		{
			int[] revertArray = new int[array.Length];
			int index = 0;

			for (int i = array.Length - 1; i >= 0; i--)
            {
				revertArray[index] = array[i];
				index++;
			}

			return revertArray;
		}
		
		#endregion
	}
}