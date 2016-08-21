using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;
	public Text scoreText;
	public EnemyController enemy;

	private void Start () {
		UpdateScore ();
		InstantiateNewEnemy ();
	}

	public void UpdateScore () {
		scoreText.text = score.ToString ();
		if (score % 5 == 0 && score > 0) {
			InstantiateNewEnemy ();
		}
	}

	public void GameOver () {
		score = 0;
		UpdateScore ();
	}

	private void InstantiateNewEnemy () {
		Instantiate (enemy, transform.position + Vector3.up * 10f, Quaternion.identity);
	}

}
