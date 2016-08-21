﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float xRad, yRad;
	public float speed = 1f;
	public float xOff, yOff;

	protected CircleGenerator[] circleGens;
	protected CircleGenerator nullCircle;
	protected float xPos, yPos, angle;


	protected CircleGenerator FindCircle (string circleTag) {
		CircleGenerator circle;
		circleGens = GameObject.FindObjectsOfType<CircleGenerator> ();
		foreach (CircleGenerator circleGen in circleGens) {
			if (circleGen.gameObject.tag == circleTag) {
				circle = circleGen;

				xOff = circle.xOff;
				yOff = circle.yOff;
				xRad = circle.xRad;
				yRad = circle.yRad;

				return circle;
			}
		}
		return nullCircle;
	}

	protected void FollowCircle () {
		angle += Time.deltaTime * speed;

		xPos = Mathf.Sin (angle) * xRad;
		yPos = Mathf.Cos (angle) * yRad;

		transform.position = new Vector2 (xPos + xOff, yPos + yOff);
	}
}
