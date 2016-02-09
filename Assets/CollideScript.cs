using UnityEngine;
using System.Collections;

public class CollideScript : MonoBehaviour {

    private float breite;
    private float radius;
    public float velocityChangeRate;
	// Use this for initialization
	void Start () {
	    breite = gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
        radius = breite / 2;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        print("MUH");
        if (col.gameObject.name == "Ball")
        {
            
            float x = col.transform.position.x - gameObject.transform.position.x;
            float y = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x, 2));
            Vector2 vec = new Vector2(x, y);

            Vector2 oldVel = col.attachedRigidbody.velocity;
            float oldLength = Mathf.Sqrt(Mathf.Pow(oldVel.x, 2) + Mathf.Pow(oldVel.y, 2));
            Vector2 nvec = vec.normalized;
            Vector2 newVel = nvec * oldLength * velocityChangeRate;
            col.attachedRigidbody.velocity = newVel;

            print( "Old Velocity: " + oldVel.magnitude + "\n" +
                "New Velocity: " + newVel.magnitude);
        }

    }
}