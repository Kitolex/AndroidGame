using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveController : MonoBehaviour {

    public List<Vector3> listPos ; 
    public List<Quaternion> listForward;

    public float vitesse;
    public float rotation;

    Rigidbody2D rb;
    bool left = false;
    bool right = false;

	// Use this for initialization
	void Start () {
         rb = GetComponent<Rigidbody2D>();
        listPos = new List<Vector3>();
        listForward = new List<Quaternion>();

    }
	
	// Update is called once per frame
	void Update () {

        if (left)
        {
            transform.Rotate(0, 0, rotation); //tourne à gauche
        }else if (right)
        {
            transform.Rotate(0, 0, -rotation); //tourne à droite
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * vitesse;// vaisseau se déplace toujours devant lui
        listPos.Add(transform.position);
        listForward.Add(transform.rotation);
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

    public List<Vector3> getPosition()
    {
        return listPos;
    }

    public List<Quaternion> getForward()
    {
        return listForward;
    }

}
