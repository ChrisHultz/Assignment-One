using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
	
	public Text playerText;

    public void Awake() {
		playerText.text = PlayerName.pass;
	}
}
