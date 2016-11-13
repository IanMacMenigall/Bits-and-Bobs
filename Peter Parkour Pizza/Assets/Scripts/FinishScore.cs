using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinishScore : MonoBehaviour {


    public Text score;
	
	// Update is called once per frame
	void Update () {

        score.text = "Score: "+Scoring.count.ToString("F0");
	}
}
