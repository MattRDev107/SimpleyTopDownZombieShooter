using UnityEngine;

namespace TDS.Weapons
{
	public interface IFireBullet
	{
		public void FireBullet(Vector3 startPosition, Vector3 aimDirection, float range);
	}
}