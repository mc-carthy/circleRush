using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float speed = 1f;

	protected CircleGenerator[] circleGens;
	protected CircleGenerator nullCircle;
	protected float xPos, yPos, angle;
	protected float xRad, yRad;
	protected float xOff, yOff;


	protected void FindCircle (string circleTag) {
		CircleGenerator circle;
		circleGens = GameObject.FindObjectsOfType<CircleGenerator> ();
		foreach (CircleGenerator circleGen in circleGens) {
			if (circleGen.gameObject.tag == circleTag) {
				circle = circleGen;
				xOff = circle.xOff;
				yOff = circle.yOff;
				xRad = circle.xRad;
				yRad = circle.yRad;
			}
		}
	}

	protected void FollowCircle () {
		angle += Time.deltaTime * speed;

		xPos = Mathf.Sin (angle) * xRad;
		yPos = Mathf.Cos (angle) * yRad;

		transform.position = new Vector2 (xPos + xOff, yPos + yOff);
	}
}
