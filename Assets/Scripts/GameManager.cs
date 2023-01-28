using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public Text playerText;

	public void Awake() {
		playerText.text = PlayerName.pass;
	}

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
		Debug.Log("LEVEL COMPLETE");
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}