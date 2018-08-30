using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveController : MonoBehaviour {

    public float vitesse;
    public float rotation;

    public Button t;

    Rigidbody2D rb;
    bool left = false;
    bool right = false;

	// Use this for initialization
	void Start () {

         rb = GetComponent<Rigidbody2D>();

        
	}
	
	// Update is called once per frame
	void Update () {



        if (left)
        {
            transform.Rotate(0, 0, rotation);
        }else if (right)
        {
            transform.Rotate(0, 0, -rotation);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * vitesse;
    }

    public void RotateLeft()
    {
        left = true;
    }

    public void RotateRight()
    {
        right = true;
    }

    public void StopRotate()
    {
        left = false;
        right = false;
    }


}
