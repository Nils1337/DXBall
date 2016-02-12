using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    public Vector2 startingVelocity;
    private bool _started = false;
    private bool _velocityChanged = false;
    public Rigidbody2D rigidBody;

    public bool started
    {
        get
        {
            return _started;
        }

        set
        {
            _started = value;
        }
    }

    public bool velocityChanged
    {
        get
        {
            return _velocityChanged;
        }

        set
        {
            _velocityChanged = value;
        }
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (!started && Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<FixedJoint2D>().enabled = false;
            rigidBody.velocity = startingVelocity;
            started = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("MUH");
    }
}
