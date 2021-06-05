using UnityEngine;

namespace TDS.Weapons.FireBulletTypes
{
	public class RayCastBullet : MonoBehaviour, IFireBullet
	{
		public void FireBullet(Vector3 startPosition, Vector3 aimDirection, float range)
		{
			RaycastHit2D hit = Physics2D.Raycast(startPosition, aimDirection);
			Debug.DrawRay(startPosition, aimDirection * range, Color.red, 0.5f);

			if (hit.collider != null)
			{
				Debug.Log("Hit a Target!");
			}
			else
			{
				Debug.Log("Miss Target!");
			}
		}
	}
}
