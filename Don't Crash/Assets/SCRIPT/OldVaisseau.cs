using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldVaisseau : MonoBehaviour {

    public List<Vector3> listPos;
    public List<Quaternion> listFor;
    public bool canStart;
    public int i=0;
    

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void FixedUpdate()
    {
        Debug.Log("dd"+canStart);
        if (canStart)
        {
            if (i < listPos.Count)
            {
                
                gameObject.transform.position = listPos[i];
                gameObject.transform.rotation = listFor[i];
                i++;
            }
        }

    }

    public void setListPos(List<Vector3> listPos)
    {
        this.listPos = listPos;
    }
    public void setlistFor(List<Quaternion> listFor)
    {
        this.listFor = listFor;
    }

    public void start()
    {
        canStart = true;
    }


}
