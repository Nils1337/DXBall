using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndZoneScript : MonoBehaviour {

    public int lifeCount;
    public Text lifeText;
    public GameObject ball;
    public GameObject schieber;
    public Vector3 ballStartPosition = new Vector3(0, -4.83f , -1);
    public Vector3 schieberStartPosition = new Vector3(0, -5, -1);
	// Use this for initialization
	void Start () {
        lifeText.text = lifeCount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (lifeCount > 0)
        {
            lifeCount--;
            lifeText.text = lifeCount.ToString();

            ball.transform.position = ballStartPosition;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            ball.GetComponent<FixedJoint2D>().enabled = true;
            ball.GetComponent<MoveScript>().started = false;
            schieber.transform.position = schieberStartPosition;
            schieber.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);


        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
