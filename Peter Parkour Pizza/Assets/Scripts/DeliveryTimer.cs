using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeliveryTimer : MonoBehaviour {
    // Update is called once per frame

    public Text Timer;

    public static float timer = 120;

    void Update () {
        timer -= Time.deltaTime;
        SetCountText();


        if (timer <= 0)
        {
            SceneManager.LoadScene("LoseMenu");

        }

	
	}
    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        Timer.text = minutes + ":" + seconds;

    }
}
