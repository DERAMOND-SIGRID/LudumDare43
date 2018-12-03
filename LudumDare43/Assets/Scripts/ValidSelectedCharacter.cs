using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidSelectedCharacter : MonoBehaviour
{

    private GameManager scr;

    private string character;
    public void SetCharacter(string name) { character = name; }

    // Use this for initialization
    void Start()
    {
        scr = Camera.main.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ValidSelection()
    {
        if (character == "Warrior")
        {
            scr.InstantiateNewWarrior();
            scr.DestroyMenuSelection();
        }
        else if (character == "Archer")
        {
            scr.InstantiateNewArcher();
            scr.DestroyMenuSelection();
        }
        else if (character == "Picklock")
        {
            scr.InstantiateNewPicklock();
            scr.DestroyMenuSelection();
        }

        

    }

}
