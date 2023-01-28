using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goToCredits() {
        SceneManager.LoadScene("Credits");
    }

    public void goToSettings() {
        SceneManager.LoadScene("Settings");
    }

    public void goToPlay() {
        SceneManager.LoadScene("HowtoPlay");
    }
}