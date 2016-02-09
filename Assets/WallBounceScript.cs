using UnityEngine;
using System.Collections;

public class WallBounceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Vector2 oldVel = col.attachedRigidbody.velocity;

        Vector2 normal;
        if (gameObject.transform.rotation.z == 0)
            normal = new Vector2(1, 0);
        else
            normal = new Vector2(0, 1);

        Vector2 newVel = oldVel - 2 * (Vector2.Dot(oldVel,normal)) * normal;
        col.attachedRigidbody.velocity = newVel;
    }
}
