using UnityEngine;

public class TopDownCameraBuilder
{
	private GameObject _gameObject;
	private GameObject _target;
	
	public TopDownCameraBuilder()
	{
		_gameObject = new GameObject();
	}

	public TopDownCameraBuilder with<TComponents>() where TComponents : Component
	{
		_gameObject.AddComponent<TComponents>();
		return this;
	}

	public TopDownCameraBuilder withPosition(float x, float y, float z)
	{
		_gameObject.transform.position = new Vector3(x, y, z);
		return this;
	}

	public TopDownCameraBuilder withTarget(GameObject target)
	{
		_target = target;
		return this;
	}

	public TopDownCamera Build()
	{
		TopDownCamera camera = _gameObject.AddComponent<TopDownCamera>();
		camera.Target = _target;

		return camera;
	}

	public static implicit operator TopDownCamera(TopDownCameraBuilder builder)
	{
		return builder.Build();
	}
}