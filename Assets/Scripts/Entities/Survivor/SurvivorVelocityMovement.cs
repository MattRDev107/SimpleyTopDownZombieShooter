using System.Collections;
using System.Runtime.CompilerServices;
using TDS.Core;
using UnityEngine;

namespace TDS.Entites.Survivor
{
	public class SurvivorVelocityMovement : MonoBehaviour, IMovement
	{

		private Rigidbody2D _rb;

		private void Awake()
		{
			_rb = gameObject.GetComponent<Rigidbody2D>();
		}

		public void HandleMovement(Vector2 movement)
		{
			_rb.velocity = movement;
		}
	}
}