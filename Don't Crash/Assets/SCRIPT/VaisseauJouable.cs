using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaisseauJouable : MonoBehaviour {

    private MoveController moveController;


	// Use this for initialization
	void Start () {

        moveController = GetComponent<MoveController>();
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

}
