using UnityEngine;

public class SurvivorBuilder
{
	private GameObject _gameObject;
	private float _moveSpeed;

	public SurvivorBuilder()
	{
		_gameObject = new GameObject();
	}

	public SurvivorBuilder With<TComponent>() where TComponent : Component
	{
		_gameObject.AddComponent<TComponent>();
		return this;
	}

	public SurvivorBuilder WithMoveSpeed(float moveSpeed)
	{
		this._moveSpeed = moveSpeed;
		return this;
	}

	private Survivor Build()
	{
		var surviver = _gameObject.AddComponent<Survivor>();
		surviver.MoveSpeed = _moveSpeed;
		return surviver;
	}

	public static implicit operator Survivor(SurvivorBuilder builder)
	{
		return builder.Build();
	}

}