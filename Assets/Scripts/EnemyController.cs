using UnityEngine;
using System.Collections;

public class EnemyController : BallController {

	public float minSpeed = 1f;
	public float maxSpeed = 3f;

	private CircleGenerator enemyCircle;
	private float dir;

	private void Start () {
		if (Random.value < 0.5f) {
			dir = 1f;
		} else {
			dir = -1f;
		}
		speed = Random.Range (minSpeed, maxSpeed);
		speed *= dir;
		FindCircle("enemyCircle");
	}


	private void Update () {
		FollowCircle ();
	}
}
