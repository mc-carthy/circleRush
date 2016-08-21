using UnityEngine;
using System.Collections;

public class CircleGenerator : MonoBehaviour {

	public float xRad, yRad;
	public float xOff, yOff;
	public int segments;
	public Color startCol = Color.white;
	public Color endCol = Color.white;

	private LineRenderer line;
	private float xPos, yPos;

	private void Start () {
		line = GetComponent<LineRenderer>();
		line.SetVertexCount(segments + 1);
		line.useWorldSpace = false;

		CreatePoints ();
	}

	private void FixedUpdate () {
		transform.position = new Vector3 (xOff, yOff, 0f);
	}



	private void CreatePoints () {

		float angle = 0f;

		for (int i = 0; i < segments + 1; i++) {
			xPos = Mathf.Sin (Mathf.Deg2Rad * angle) * xRad;
			yPos = Mathf.Cos (Mathf.Deg2Rad * angle) * yRad;

			line.SetPosition(i, new Vector3(xPos, yPos, 0));
			line.material = new Material (Shader.Find("Particles/Additive"));
			line.SetWidth (0.1f, 0.1f);
			line.SetColors (startCol, endCol);

			angle += (360 / segments);
		}
	}
}
