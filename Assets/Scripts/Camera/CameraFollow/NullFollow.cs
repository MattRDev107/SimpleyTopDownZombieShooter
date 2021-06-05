using System.Collections;
using TDS.Core;
using UnityEngine;

namespace TDS.TopdownCamera.CameraFollow
{
	public class NullFollow : MonoBehaviour, IFollow
	{
		public Vector3 GetPosition()
		{
			return transform.position;
		}

		public void UpdateTargetPosition(Vector3 position)
		{

		}
	}
}