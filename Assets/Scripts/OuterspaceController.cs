using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterspaceController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.08f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;

	//private variables
	private Transform transform;
	private Vector2 currentPos;

	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		currentPos = transform.position;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		currentPos = transform.position;
		//move outerspace to the left
		currentPos -= new Vector2 (speed,0);

		//check if we need to reset
		if (currentPos.x < endX) {
			//reset
			Reset ();
		}
		//apply changes
		transform.position = currentPos;

	}


	private void Reset(){

		currentPos = new Vector2 (startX,0);
	}
}
