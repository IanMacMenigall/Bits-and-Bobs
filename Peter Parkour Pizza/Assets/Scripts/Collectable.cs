using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("pepperoni"))
            {
                HealthBar.playerHealth = HealthBar.playerHealth + 10;
            }
            else if (gameObject.CompareTag("tomato"))
            {
                HealthBar.playerHealth = HealthBar.playerHealth + 12;
            }
            else if (gameObject.CompareTag("mushroom"))
            {
                HealthBar.playerHealth = HealthBar.playerHealth + 15;
            }

            Destroy(gameObject);
        }
    }
}
