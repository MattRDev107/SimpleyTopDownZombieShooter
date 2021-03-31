using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class TopDownCamera : MonoBehaviour
{
	public GameObject Target { get => _target; set => _target = value; }
	[SerializeField]private GameObject _target;

	private float _offsetZ = 10.0f;
	private Vector3 _targetPos;

	private void Start()
	{
		RepostionCamera();
	}

	public void RepostionCamera()
	{
		_targetPos = _target.transform.position;
		gameObject.transform.position = new Vector3(_targetPos.x, _targetPos.y, _offsetZ);
	}
}
