using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	
	public Text score;          //Store a reference to the UI Text component which will display the number of pickups collected.
	

	
	private int count;              //Integer to store the number of pickups collected so far.

	// Use this for initialization
	void Start()
	{
		//Initialize count to zero.
		count = 0;

		//Call our SetCountText function which will update the text with the current value for count.
		SetCountText ();
	}



	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D(Collider2D other) 
	{
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("pepperoni"))
        {

            //... then set the other object we just collided with to inactive.
            //other.gameObject.SetActive(false);

            //Add one to the current value of our count variable.
            count = count + 100;

            //Update the currently displayed count by calling the SetCountText function.
            SetCountText();
        }

        else if (other.gameObject.CompareTag("tomato"))
        {
            count = count + 120;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("mushroom"))
        {
            count = count + 150;
            SetCountText();
        }


    }

	//This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
	void SetCountText()
	{
		//Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
		score.text = "Score: " + count.ToString ();


	}
}