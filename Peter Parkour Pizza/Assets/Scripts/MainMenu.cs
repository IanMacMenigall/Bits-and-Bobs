using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas quitConfirm;
	public Button startGametxt;
	public Button quitGametxt;

	void Start(){

		quitConfirm = quitConfirm.GetComponent<Canvas>();
		startGametxt = startGametxt.GetComponent<Button> ();
		quitGametxt = quitGametxt.GetComponent<Button> ();
		quitConfirm.enabled = false;

	}

	public void QuitPress() // this function will be used on the Quit button

	{
		quitConfirm.enabled = true;     // enable the Quit menu when the 'Quit' button is clicked
		startGametxt.enabled = false;   // prevent these buttons from being clicked
		quitGametxt.enabled = false;

	}

	public void NoPress()   // this function will be used for the 'NO' button in the Quit Menu

	{
		quitConfirm.enabled = false;    // Disable the Quit menu, meaning it won't be visible anymore
		startGametxt.enabled = true;    // Enable the 'Play' and 'Exit' buttons again so they can be clicked
		quitGametxt.enabled = true;

	}

	public void StartLevel () // this function will be used on the 'Play' button

	{
		// calls the 'MainLevel' scene
		SceneManager.LoadScene("MainLevel");

	}

	public void ExitGame () // this function will be used on the "Yes" button in our Quit menu

	{
		Application.Quit(); // Quit the game. Note that this will only work after building the game

	}

} 