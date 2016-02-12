using UnityEngine;
using System.Collections;

public class BlockCollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if (!col.gameObject.GetComponent<MoveScript>().velocityChanged)
        {
            Vector3 blockPosition = gameObject.GetComponent<BoxCollider2D>().bounds.center;
            Vector3 blockExtents = gameObject.GetComponent<BoxCollider2D>().bounds.extents;
            Vector3 ballPosition = col.gameObject.GetComponent<CircleCollider2D>().bounds.center;
            Vector3 ballExtents = col.gameObject.GetComponent<CircleCollider2D>().bounds.extents;
            Vector2 normal;
            if ((ballPosition.x < blockPosition.x + blockExtents.x + ballExtents.x) && (ballPosition.x > blockPosition.x - blockExtents.x - ballExtents.x))
            {
                normal = new Vector2(0, 1);
            }
            else
            {
                normal = new Vector2(1, 0);
            }

            Vector2 oldVel = col.attachedRigidbody.velocity;
            Vector2 newVel = oldVel - 2 * (Vector2.Dot(oldVel, normal)) * normal;
            print("Block Collision\noldVel: " + oldVel + "\nnewVel: " + newVel + "\n");
            col.attachedRigidbody.velocity = newVel;
            col.gameObject.GetComponent<MoveScript>().velocityChanged = true;
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        col.gameObject.GetComponent<MoveScript>().velocityChanged = false;
        gameObject.SetActive(false);

        if (GameObject.FindGameObjectsWithTag("Finish").Length == 0)
        {
            Time.timeScale = 0;
        }
    }
}
