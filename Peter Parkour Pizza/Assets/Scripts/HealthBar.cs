using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;
    public Slider healthBar;


   
    // Use this for initialization
    void Start()
    {

        healthBar = GetComponent<Slider>();

        //Initialize playerHealth to zero.
        playerHealth = maxPlayerHealth; //PlayerPrefs.GetInt("PlayerCurrentHealth");

        //Call our SetplayerHealthText function which will update the text with the current value for playerHealth.
      //  Update();
    }



    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    //void OnTriggerEnter2D(Collider2D other)
    void OnTriggerStay2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("rubbish"))
        {

            //... then set the other object we just collided with to inactive.
            //other.gameObject.SetActive(false);

            //Add one to the current value of our playerHealth variable.
            playerHealth = playerHealth - 1;

            //Update the currently displayed playerHealth by calling the SetplayerHealthText function.
            Update();
        }

        else if (other.gameObject.CompareTag("pizzaCutter"))
        {
            playerHealth = playerHealth - 2;
            Update();
            
        }
        else if (other.gameObject.CompareTag("flames"))
        {
            playerHealth = playerHealth - 2;
            Update();
        }
        else if (other.gameObject.CompareTag("EnemyCabbage"))
        {
            playerHealth = playerHealth - 50;

            Update();
            Destroy(gameObject);



        }
        else if (other.gameObject.CompareTag("EnemyPineapple"))
        {
            playerHealth = playerHealth - 100;

            Update();
            Destroy(other.gameObject.CompareTag("EnemyPineapple"));


        }


    }

    /*void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyCabbage"))
        {
            playerHealth = playerHealth - 50;
            
            Update();

        }
        else if (other.gameObject.CompareTag("EnemyPineapple"))
        {
            playerHealth = playerHealth - 100;

            Update();

        }
    }*/

    void Update()
    {

        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("LoseMenu");

        }

        healthBar.value = playerHealth;
    }
}