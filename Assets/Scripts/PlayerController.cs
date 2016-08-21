using UnityEngine;
using System.Collections;

public class PlayerController : BallController {

	public float speedDelta = 0.1f;

	private CircleGenerator playerCircle;

	private void Start () {
		playerCircle = FindCircle ("playerCircle");
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
}
