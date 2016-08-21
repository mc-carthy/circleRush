using UnityEngine;
using System.Collections;

public class EnemyController : BallController {

	private CircleGenerator enemyCircle;
	private float dir;


	private void Start () {
		if (Random.value < 0.5f) {
			dir = 1f;
		} else {
			dir = -1f;
		}
		speed *= dir;
		FindCircle("enemyCircle");
	}


	private void Update () {
		FollowCircle ();
	}
}
