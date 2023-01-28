using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {
    public void backtoMenu() {
        SceneManager.LoadScene("Menu");
    }
}
