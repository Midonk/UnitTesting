using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
	public class Array_ex08
	{
		#region Publics

		public int m_gunnerPower;
		public int m_heavyGunnerPower;
		public int m_rocketLauncherPower;

		#endregion


		#region Constructor

		public Array_ex08(int gunnerPower = 4, int heavyGunnerPower = 9, int rocketLauncherPower = 16)
		{
			m_gunnerPower = gunnerPower;
			m_heavyGunnerPower = heavyGunnerPower;
			m_rocketLauncherPower = rocketLauncherPower;
		}

		#endregion

		#region Main

		/// Nos escouades de soldats sont prêtes, nous avons 3 types:
		/// Les soldats, les soldats lourds et les soldats lance-roquette
		/// Ils se sont regroupés en plusieurs escouades
		/// Déterminer la puissance de feu pour chaque escouade
		public int[] GetSquadsPower(SoldierType[,] squads)
		{
			return new int[0];
		}

		#endregion
	}
}

// pas touche
public enum SoldierType
{
	GUNNER,
	HEAVYGUNNER,
	ROCKETLAUNCHER
}