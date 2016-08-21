using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;
	public Text scoreText;

	public void UpdateScore() {
		scoreText.text = score.ToString ();
	}

}
