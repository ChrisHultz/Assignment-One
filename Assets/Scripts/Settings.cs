using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public static float PlayerSpeed;

    public Slider speedSlider;

    public Text sliderText;

    public void backToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void sliderNumber() {
        sliderText.text = speedSlider.value.ToString();
        PlayerSpeed = speedSlider.value;
    }


}
