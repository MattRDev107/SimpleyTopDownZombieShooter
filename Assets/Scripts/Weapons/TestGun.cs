using System;
using System.Collections;
using UnityEngine;

namespace TDS.Weapons
{
    public class TestGun : MonoBehaviour, IWeapon
    {
		public float _range = 25.0f;
		public Transform _endOfBarral;
		private bool _canFire;
        private Vector2 _direction;
        private GameObject _projectile;

		private IFireBullet _bullet;

		public void Awake()
		{
			_bullet = gameObject.GetComponent<IFireBullet>();
		}

		public void Fire(bool canFire)
		{
			_bullet.FireBullet(_endOfBarral.position, transform.up, _range);
		}

		public void Reload()
		{

		}

		private IEnumerator RepeatFire(bool canFire)
		{
			yield return null;
		}
	}
}
