using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Vector3 posInit; // position initial à modifier plus tard 

  

    public VaisseauJouable vaisseauJouable;
    public GhostVaisseau ghostVaisseau;
    private RecordVaisseauSystem rvs;




    // Use this for initialization
    void Start () {
        vaisseauJouable.transform.position = posInit;
        rvs = GetComponent<RecordVaisseauSystem>();
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
        Debug.Log("touhe");
        vaisseauJouable.gameObject.SetActive(false);
        createGhost();
        vaisseauJouable.gameObject.transform.position = new Vector3(6, -16, 0);//TODO*/
    }

    private void createGhost()
    {
        GhostVaisseau gV = Instantiate(ghostVaisseau);
        gV.name = "Ghost";
        gV.transform.position = posInit;//TODO
        gV.record= rvs.getRecord();
        gV.gameObject.SetActive(true);

    }
}
