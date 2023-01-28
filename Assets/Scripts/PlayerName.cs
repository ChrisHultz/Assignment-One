using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {
    public InputField input;
    public Text inputText;
    public static string pass;

    public void inputName() {
        pass = input.text.ToString();
        inputText.text = pass.ToUpper();
    }
}
