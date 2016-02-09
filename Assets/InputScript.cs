using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {

    public Rigidbody2D rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        //rigidBody.velocity = new Vector2(1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(h*3, 0);
	}
}
