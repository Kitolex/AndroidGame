using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaisseauJouable : Vaisseau
{

    
    private GameManager gm;
    private RecordVaisseauSystem recordSystem;





    // Use this for initialization
    void Start () {

        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        recordSystem = GameObject.FindGameObjectWithTag("GameManager").GetComponent<RecordVaisseauSystem>();
        moveController = GetComponent<MoveController>();

        moveController.etat = InputGame.none;
        
    }

    private void FixedUpdate()
    {
        State s = new State();
        s.rotation = transform.rotation;
        recordSystem.addState(s);
    }

    public void InputLeft()
    {
        
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

        moveController.etat = InputGame.none;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Cible"))
        {
            other.gameObject.SetActive(false);
            gm.arriveObj();
        }
    }

}
