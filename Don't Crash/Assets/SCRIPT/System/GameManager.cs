using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Vector3 posInit; // position initial à modifier plus tard 

  

    public VaisseauJouable vaisseauJouable;
    public OldVaisseau oldVaisseau;


    // Use this for initialization
    void Start () {
        vaisseauJouable.gameObject.transform.position = posInit;
        vaisseauJouable.gameObject.SetActive(true);
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void arrive()
    {
        vaisseauJouable.gameObject.SetActive(false);
        Debug.Log("WIN");
        restart();
    }

    private void restart()
    {
        createGhost();
        vaisseauJouable.gameObject.transform.position = posInit;
        vaisseauJouable.gameObject.transform.forward = Vector3.zero;
        vaisseauJouable.gameObject.SetActive(true);
    }

    private void createGhost()
    {
        OldVaisseau oV = Instantiate(oldVaisseau);
        List<Vector3> listPos = vaisseauJouable.gameObject.GetComponent<MoveController>().getPosition();
        List<Quaternion> listFor = vaisseauJouable.gameObject.GetComponent<MoveController>().getForward();
        oV.gameObject.SetActive(true);
        oV.setListPos(listPos);
        oV.setlistFor(listFor);
        oV.start();
       
    }
}
