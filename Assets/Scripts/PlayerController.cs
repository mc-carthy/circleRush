using UnityEngine;
using System.Collections;

public class PlayerController : BallController {

	public float speedDelta = 0.1f;

	private CircleGenerator playerCircle;
	private GameManager gm;

	private void Start () {
		FindCircle("playerCircle");
		gm = FindObjectOfType<GameManager> ();
	}


	private void Update () {
		AlterSpeed ();
		FollowCircle ();
	}
		
	private void AlterSpeed () {
		if (Input.GetKey (KeyCode.A)) {
			speed -= speedDelta;
		}
		if (Input.GetKey (KeyCode.D)) {
			speed += speedDelta;
		}
		speed = Mathf.Clamp (speed, 0f, 5f);
	}

	private void OnTriggerEnter2D (Collider2D col) {
		Debug.Log ("Collision!");
		if (col.gameObject.tag == "lapLine") {
			gm.score++;
			Debug.Log (gm.score.ToString ());
			gm.UpdateScore ();
		}
	}
}
