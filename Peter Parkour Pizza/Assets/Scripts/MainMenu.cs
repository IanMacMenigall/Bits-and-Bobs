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

	public void QuitPress() //this function will be used on our Quit button

	{
		quitConfirm.enabled = true; //enable the Quit menu when we click the Quit button
		startGametxt.enabled = false; //prevent these buttons from being clicked
		quitGametxt.enabled = false;

	}

	public void NoPress() //this function will be used for our "NO" button in our Quit Menu

	{
		quitConfirm.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
		startGametxt.enabled = true; //enable the Play and Exit buttons again so they can be clicked
		quitGametxt.enabled = true;

	}

	public void StartLevel () //this function will be used on our Play button

	{
		//calls the Main level scene
		SceneManager.LoadScene("MainLevel");

	}

	public void ExitGame () //This function will be used on our "Yes" button in our Quit menu

	{
		Application.Quit(); //this will quit our game. Note this will only work after building the game

	}

} 