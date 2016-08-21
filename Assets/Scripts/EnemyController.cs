using UnityEngine;
using System.Collections;

public class EnemyController : BallController {

	private CircleGenerator enemyCircle;


	private void Start () {
		enemyCircle = FindCircle ("enemyCircle");
	}


	private void Update () {
		FollowCircle ();
	}
}
