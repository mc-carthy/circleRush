using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score;
	public Text scoreText;
	public EnemyController enemy;

	private void Start () {
		UpdateScore ();
		InstantiateNewEnemy ();
	}

	private void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			ReloadScene ();
		}
	}

	public void UpdateScore () {
		scoreText.text = score.ToString ();
		if (score % 5 == 0 && score > 0) {
			InstantiateNewEnemy ();
		}
	}

	public void GameOver () {
	}

	private void InstantiateNewEnemy () {
		Instantiate (enemy, transform.position + Vector3.up * 10f, Quaternion.identity);
	}

	private void ReloadScene() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
	}
}
