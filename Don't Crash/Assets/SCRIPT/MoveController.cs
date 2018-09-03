using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveController : MonoBehaviour {

    private Rigidbody rb;
    public VaisseauStat vaisseauStat;
    public InputGame etat;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        etat = InputGame.none;


    }


    private void FixedUpdate()
    {
      
        rb.velocity = transform.up * vaisseauStat.vitesse;// vaisseau se déplace toujours devant lui

        switch (etat)
        {
            case InputGame.left:
                transform.Rotate(0, 0, vaisseauStat.rotation);
                break;
            case InputGame.right:
                transform.Rotate(0, 0, -vaisseauStat.rotation);
                break;

        }

    }


}