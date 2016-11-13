using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class DeliveryTimer : MonoBehaviour {
    // Update is called once per frame

    public Text Timer;

    public float timer = 300;

    void Update () {
        timer -= Time.deltaTime;
        SetCountText();


        if (timer <= 0)
        {
            Application.LoadLevel("LoseMenu");

        }

	
	}
    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        Timer.text = "Delivery Time: " + minutes + ":" + seconds;

    }
}
