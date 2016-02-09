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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            ContactPoint2D[] points = col.contacts;
            int middle = points.Length / 2;
            ContactPoint2D point = points[middle];
            float x = point.point.x - gameObject.transform.position.x;
            float y = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x, 2));
            Vector2 vec = new Vector2(x, y);

            Vector2 oldVel = col.rigidbody.velocity;
            float oldLength = Mathf.Sqrt(Mathf.Pow(oldVel.x, 2) + Mathf.Pow(oldVel.y, 2));
            Vector2 nvec = vec.normalized;
            Vector2 newVel = nvec * oldLength * velocityChangeRate;
            col.rigidbody.velocity = newVel;
        }

    }
}