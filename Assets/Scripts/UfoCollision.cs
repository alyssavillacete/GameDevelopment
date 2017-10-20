using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	[SerializeField]
	GameObject explosion;


	private AudioSource[] sounds;
	private AudioSource starSound;
	private AudioSource explosionSound;

	// Use this for initialization
	void Start () {
		sounds = gameObject.GetComponents<AudioSource> ();
		explosionSound = sounds [0];
		starSound = sounds [1];

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag.Equals ("star")) {
			Debug.Log ("Collision star\n");
			Player.Instance.Score += 100;
			if (starSound != null) {
				starSound.Play ();
			}

		} else if (other.gameObject.tag.Equals ("asteroid")) {
			Debug.Log ("Collision asteroid\n");

			if (explosionSound != null) {
				explosionSound.Play ();
			}

			Instantiate (explosion).GetComponent<Transform> ().position = other.gameObject.GetComponent<Transform> ().position;
			other.gameObject.GetComponent<AsteroidController> ().Reset ();
			Player.Instance.Life -= 1;


		}

	}
}
