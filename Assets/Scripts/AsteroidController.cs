using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

	[SerializeField]
	float minYSpeed = -0.01f;
	[SerializeField]
	float maxYSpeed = 0.03f;
	[SerializeField]
	float minXSpeed = -0.01f;
	[SerializeField]
	float maxXSpeed = 0.03f;

	private Transform transform;
	private Vector2 currentSpeed;
	private Vector2 currentPosition;

	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		Reset ();
	}

	public void Reset(){

		float xSpeed = Random.Range (minXSpeed, maxXSpeed);
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		currentSpeed = new Vector2 (xSpeed, ySpeed);

		transform.position = new Vector2 (Random.Range (0, 3), Random.Range (0,1));

	}

	// Update is called once per frame
	void Update () {
		currentPosition = transform.position;
		currentPosition -= currentSpeed;
		transform.position = currentPosition;

		if (currentPosition.x < -3) {
			Reset ();
		}
	}
}

