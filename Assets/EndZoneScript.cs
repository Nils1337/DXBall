using UnityEngine;
using System.Collections;

public class EndZoneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Time.timeScale = 0;
    }
}
