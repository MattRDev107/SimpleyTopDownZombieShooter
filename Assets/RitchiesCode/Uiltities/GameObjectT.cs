using System.Collections;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace RitchiesCode.Assets.RitchiesCode.Uiltities
{
	public static class GameObjectT
	{
		public static GameObject FindChildGameObjectWithName(GameObject parent, string nameOfChild)
		{
			foreach (Transform eachChild in parent.transform)
			{
				if(eachChild.name == nameOfChild)
				{
					return eachChild.gameObject;
				}
			}

			return null;
		}
	}
}