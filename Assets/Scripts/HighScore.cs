using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class HighScore : MonoBehaviour {

    static public int score = 1000;
	// Use this for initialization
	void Awake () {
	    if(PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
	} 
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        if(score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
	}
}
