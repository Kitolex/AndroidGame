using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveController : MonoBehaviour {

    private Rigidbody rb;
    public InputGame etat;
    private Vaisseau vaisseau;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        vaisseau = GetComponent<Vaisseau>();
    }


    private void FixedUpdate()
    {
        rb.velocity = transform.up * vaisseau.vaisseauStat.vitesse;// vaisseau se déplace toujours devant lui

        switch (etat)
        {
            case InputGame.left:
                transform.Rotate(0, 0, vaisseau.vaisseauStat.rotation);
                break;
            case InputGame.right:
                transform.Rotate(0, 0, -vaisseau.vaisseauStat.rotation);
                break;

        }
    }
}