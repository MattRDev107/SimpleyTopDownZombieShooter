using System;
using System.Collections;
using MoonlanderCode.MathTools;
using NUnit.Framework;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.TestTools;
using Object = UnityEngine.Object;

namespace MoonlanderCode.Tests.PlayMode
{
	public class SurvivorTests
	{
		public class Move
		{
			[UnityTearDown]
			public IEnumerator CleanScene()
			{
				foreach (var gameObject in Object.FindObjectsOfType<GameObject>())
				{
					Object.DestroyImmediate(gameObject);
				}

				yield return new WaitForEndOfFrame();
			}

			[UnityTest]
			public IEnumerator Vector_Z_Is_Zero()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				survivor.Move(Vector2.up);

				yield return new WaitForFixedUpdate();

				Assert.AreEqual(Vector3.zero.z, survivor.transform.position.z);
			}

			[UnityTest]
			public IEnumerator No_Direction_Then_No_Change()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				survivor.Move(Vector2.zero);

				yield return new WaitForFixedUpdate();

				Assert.AreEqual(Vector3.zero, survivor.transform.position);
			}

			[UnityTest]
			public IEnumerator Up_Direction_Then_Move_Up()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				float duration = Time.time + 1.0f;
				while (Time.time < duration)
				{
					survivor.Move(Vector2.up);
					yield return new WaitForFixedUpdate();
				}

				Assert.AreEqual( new Vector3(0f, 1f,0f) * survivor.moveSpeed , MathT.VectorRound(survivor.transform.position));
			}

			[UnityTest]
			public IEnumerator Down_Direction_Then_Move_Down()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				float duration = Time.time + 1.0f;
				while (Time.time < duration)
				{
					survivor.Move(Vector2.down);
					yield return new WaitForFixedUpdate();
				}

				Assert.AreEqual(new Vector3(0f, -1f, 0f) * survivor.moveSpeed, MathT.VectorRound(survivor.transform.position));
			}

			[UnityTest]
			public IEnumerator Left_Direction_Then_Move_Left()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				float duration = Time.time + 1.0f;
				while (Time.time < duration)
				{
					survivor.Move(Vector2.left);
					yield return new WaitForFixedUpdate();
				}

				Assert.AreEqual(new Vector3(-1f, 0f, 0f) * survivor.moveSpeed, MathT.VectorRound(survivor.transform.position));
			}

			[UnityTest]
			public IEnumerator Right_Direction_Then_Move_Right()
			{
				GameObject gameObject = new GameObject();
				Survivor survivor = gameObject.AddComponent<Survivor>();
				gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

				float duration = Time.time + 1.0f;
				while (Time.time < duration)
				{
					survivor.Move(Vector2.right);
					yield return new WaitForFixedUpdate();
				}

				Assert.AreEqual(new Vector3(1f, 0f, 0f) * survivor.moveSpeed, MathT.VectorRound(survivor.transform.position));
			}
		}
	}
}