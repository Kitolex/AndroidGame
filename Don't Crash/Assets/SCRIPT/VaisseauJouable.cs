using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauJouable : MonoBehaviour {

    private MoveController moveController;
    private GameManager gm;

    public List<InputGame> listInput;
    public List<float> listTime;
    public float time;
    private int i;


	// Use this for initialization
	void Start () {
        i = 0;
        time = Time.time;
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        moveController = GetComponent<MoveController>();
    }

    private void FixedUpdate()
    {
        if (listInput.Count == 0)
        {
            if (!moveController.etat.Equals(InputGame.none))
            {
                addLists();
            }
        }
        else
        {
            if (!listInput[i].Equals(moveController.etat))
            {
                addLists();
                i++;
            }
        }



        
    }

    public void InputLeft()
    {
        
        Debug.Log("VaisseauJouable INPUT LEFT");
        if (moveController.etat.Equals(InputGame.right))
        {
            StopInput();
        }
        else
        {
            
            moveController.etat = InputGame.left;
        }
        
    }

    public void InputRight()
    {
        
        Debug.Log("VaisseauJouable INPUT RIGHT");
        if (moveController.etat.Equals(InputGame.left))
        {
            StopInput();
        }
        else
        {
 
            moveController.etat = InputGame.right;
        }
        
    }

    public void StopInput()
    {
        Debug.Log("VaisseauJouable STOP INPUT");
        moveController.etat = InputGame.none;
    }

    private void addLists()
    {
        listInput.Add(moveController.etat);
        listTime.Add(Time.time - time);
        time = Time.time;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Cible"))
        {
            other.gameObject.SetActive(false);
            addLists();
            gm.arriveObj();
        }
    }

}
