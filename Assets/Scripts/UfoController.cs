using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.1f;
	[SerializeField]
	private float bottomY;
	[SerializeField]
	private float topY;

	private Transform transform;
	private Vector2 currentPos;


	// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform> ();
		currentPos = transform.position;
	}

	// Update is called once per frame
	void Update () {

		currentPos = transform.position;

		float userInput = Input.GetAxis ("Vertical");
		 
		if(userInput<0)
		{
			//if down arrow is pressed move down
			currentPos -= new Vector2(0,speed);
		}
			
		if(userInput>0)
		{
			//if up arrow is pressed move up
			currentPos += new Vector2(0,speed);
		}

		CheckBounds ();
		transform.position = currentPos;
	}

	private void CheckBounds(){

		if (currentPos.y < bottomY) {
			currentPos.y = bottomY;
		}

		if (currentPos.y > topY) {
			currentPos.y = topY;
		}

	}
}


