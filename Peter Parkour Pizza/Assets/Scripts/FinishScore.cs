using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinishScore : MonoBehaviour {


    public Text score;
	
	// Update is called once per frame
	void Update () {

        var Xscore = Scoring.count;

        if (HealthBar.playerHealth <= 0)
        {
            score.text = Xscore.ToString("F0");
        }
        else
        {
            var Xtimer = DeliveryTimer.timer * 100;
            var total = Xtimer + Xscore;

            score.text = "Score: " + Xscore.ToString("F0") + "\nTime Bonus: " + Xtimer.ToString("F0") + "\nTotal: " + total.ToString("F0");
            //score.text = total.ToString("F0");
        }
        //score.text = "Score: "+Scoring.count.ToString("F0");
	}
}
