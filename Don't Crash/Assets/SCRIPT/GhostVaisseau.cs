using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostVaisseau : Vaisseau {


    public Record record;
    private int i;

    public void Start()
    {
        moveController = GetComponent<MoveController>();
        moveController.etat = InputGame.none;
        i = 0;
    }

    public void FixedUpdate()
    {
        Debug.Log(record.listState.Count);
        if (i < record.listState.Count)
        {
            
            transform.rotation = record.listState[i].rotation;
            i++;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    


}
