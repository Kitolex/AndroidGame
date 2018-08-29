using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    public float vitesse;
    public float rotation;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {

         rb = GetComponent<Rigidbody2D>();

        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotation);
        }else if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, -rotation);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * vitesse;
    }
}
