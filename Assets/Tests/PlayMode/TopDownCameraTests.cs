using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace TopDownShooter.Tests.PlayMode
{
	public class TopDownCameraTests
	{
		public class Resposition
		{
			[UnityTest]
			public IEnumerator Account_For_Offset() 
			{
				GameObject target = A.GameObject.WithPosition(0, 0);
				TopDownCamera camera = A.TopDownCamera
					.withPosition(1,1,0)
					.withTarget(target);

				camera.RepostionCamera();

				yield return null;

				Assert.AreEqual(new Vector3(0f, 0f, 10.0f), camera.transform.position);
			}
		}
	}
}