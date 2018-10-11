using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveController : MonoBehaviour {

    private Rigidbody rb;
    public InputGame etat;
    private Vaisseau vaisseau;
    private float vitesseVaisseau;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        vaisseau = GetComponent<Vaisseau>();
        vitesseVaisseau = vaisseau.vaisseauStat.vitesse;
    }


    private void FixedUpdate()
    {
        rb.velocity = transform.up * vitesseVaisseau;// vaisseau se déplace toujours devant lui

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

    public float getVitesse()
    {
        return vitesseVaisseau;
    }

    public void updateVitesseVaisseauWithCoef(float coeff)
    {
        vitesseVaisseau = vitesseVaisseau * (1 - coeff);
    }


    public void setNewVitesseVaisseau(float newVitesseVaisseau)
    {
        vitesseVaisseau = newVitesseVaisseau;
    }
}