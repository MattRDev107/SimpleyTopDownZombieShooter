using System;
using UnityEngine;

namespace TDS.Weapons
{
	interface IWeapon
	{
		public void Fire(bool canFire);
		public void Reload();
	}
}
