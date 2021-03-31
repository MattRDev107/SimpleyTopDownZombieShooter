using JetBrains.Annotations;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UIElements;

public static class A
{
	public static SurvivorBuilder Survivor => new SurvivorBuilder();
	public static GameObjectBuilder GameObject => new GameObjectBuilder();
	public static TopDownCameraBuilder TopDownCamera => new TopDownCameraBuilder();

}
