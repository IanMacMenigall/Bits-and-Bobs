using UnityEngine;
using System.Collections;

public class SpriteRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.back, GetComponentInParent<SimplePlatformController>().rb2d.velocity.x);
	}
}
