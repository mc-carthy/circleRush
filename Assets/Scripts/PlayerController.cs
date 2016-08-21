using UnityEngine;
using System.Collections;

public class PlayerController : BallController {

	public float speedDelta = 0.1f;

	private CircleGenerator playerCircle;
	private GameManager gm;
	private bool isGameOver;

	private void Start () {
		FindCircle("playerCircle");
		gm = FindObjectOfType<GameManager> ();
	}


	private void Update () {
		if (!isGameOver) {
			AlterSpeed ();
		}
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
		if (col.gameObject.tag == "lapLine") {
			gm.score++;
			gm.UpdateScore ();
		} else if (col.gameObject.tag == "enemy") {
			gm.GameOver ();
			isGameOver = true;
			speed = 0;
		}
	}
}
