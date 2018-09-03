using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Vector3 posInit; // position initial à modifier plus tard 

  

    public VaisseauJouable vaisseauJouable;
    public GhostVaisseau ghostVaisseau;


    // Use this for initialization
    void Start () {
        vaisseauJouable.transform.position = posInit;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /**
    *
    * Méthode quand le vaisseau arrive à une cible ou objectif
    */
    public void arriveObj()
    {
        vaisseauJouable.gameObject.SetActive(false);
        createGhost();
        vaisseauJouable.gameObject.transform.position = new Vector3(6, -16, 0);//TODO
    }

    private void createGhost()
    {
        GhostVaisseau gV = Instantiate(ghostVaisseau);
        gV.name = "Ghost";
        gV.transform.position = posInit;//TODO
        gV.listInput = new List<InputGame>(vaisseauJouable.listInput);
        gV.listTime = new List<float>(vaisseauJouable.listTime);
        gV.gameObject.SetActive(true);

    }
}
