using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float xRad, yRad;
	public float speed = 1f;
	public float speedDelta = 0.1f;
	public float xOff, yOff;

	private CircleGenerator[] circleGens;
	private CircleGenerator playerCircle;
	private float xPos, yPos, angle;

	private void Start () {
		FindPlayerCircle ();
	}


	private void Update () {
		AlterSpeed ();
		FollowCircle ();
		Debug.Log ("Speed: " + speed.ToString ());
	}

	private void FindPlayerCircle () {
		circleGens = GameObject.FindObjectsOfType<CircleGenerator> ();
		foreach (CircleGenerator circleGen in circleGens) {
			if (circleGen.gameObject.tag == "playerCircle") {
				playerCircle = circleGen;
			}
		}
		xOff = playerCircle.xOff;
		yOff = playerCircle.yOff;
		xRad = playerCircle.xRad;
		yRad = playerCircle.yRad;
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

	private void FollowCircle () {
		angle += Time.deltaTime * speed;

		xPos = Mathf.Sin (angle) * xRad;
		yPos = Mathf.Cos (angle) * yRad;

		transform.position = new Vector2 (xPos + xOff, yPos + yOff);
	}
}
