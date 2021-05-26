using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
	public class Array_ex06
	{
		#region Main

		/// 
		public int[] RevertCode(int[] code)
		{
			int[] revertCode = new int[code.Length];

			for (int i = code.Length - 1; i >= 0; i--)
            {
				revertCode[i] = code[i];
				
			}

			for (int i = 0; i < revertCode.Length; i++)
            {
				Debug.Log(code[i]);
			}

			return revertCode;
		}
			
		#endregion
	}
}