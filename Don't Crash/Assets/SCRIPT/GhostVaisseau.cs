using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostVaisseau : MonoBehaviour {

    public List<InputGame> listInput;
    public List<float> listTime;
    private MoveController mv;
    public int i = 0;
    private float time;

    public void Start()
    {
        time = Time.time;
        mv = GetComponent<MoveController>();
    }

    public void FixedUpdate()
    {
        if (i < listInput.Count)
        {     
            if (listTime[i] <= (Time.time-time))
            {
                mv.etat = listInput[i];
                i++;
                time = Time.time;
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }



}
