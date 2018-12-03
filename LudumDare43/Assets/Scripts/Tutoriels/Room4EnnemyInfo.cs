using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room4EnnemyInfo : MonoBehaviour {

    private GameObject textInfo;

    private bool alreadyExecute1;
    private bool alreadyExecute2;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");

        alreadyExecute1 = false;
        alreadyExecute2 = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (Camera.main.GetComponent<GameManager>().IsMenuSelectionNull() == true && alreadyExecute1 == false)
        {
            textInfo.GetComponent<Text>().text = "";
           
            alreadyExecute1 = true;

        }

        if (GameObject.Find("TriggerR4EI").GetComponent<CheckTrigger>().GetIsTrigger() == true && alreadyExecute2 == false)
        {
            GameObject ennemy = GameObject.Find("EnnemyListRoom4").GetComponentInChildren<EnnemyMoves>().gameObject;

            ennemy.GetComponent<EnnemyMoves>().SetCanHunt(true);
            ennemy.GetComponent<EnnemyCombat>().SetCanAttack(true);

            alreadyExecute2 = true;
        }

	}
}
