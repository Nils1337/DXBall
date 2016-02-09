using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    public Rigidbody2D rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(2, 2);
    }

    // Update is called once per frame
    void Update () {
	}

    void OnCollisionExit2D(Collision2D col)
    {
       
    }
}
