using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordVaisseauSystem : MonoBehaviour {

    private Record record;

	// Use this for initialization
	void Start () {
        record = ScriptableObject.CreateInstance<Record>();
       
    }


    public void addState(State s)
    {
        record.listState.Add(s);
    }

    public Record getRecord()
    {
        return record;
    }
}


