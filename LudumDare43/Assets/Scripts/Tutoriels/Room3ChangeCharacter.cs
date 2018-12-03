using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room3ChangeCharacter : MonoBehaviour {

    private GameObject textInfo;
    private GameObject player;

    private bool alreadyExecute1;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");

        player = GameObject.Find("Player");

        alreadyExecute1 = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Player").GetComponentInChildren<CharacterData>() == null && alreadyExecute1 == false)
        {
            textInfo.GetComponent<Text>().text = "Vous êtes mort!";

            alreadyExecute1 = true;
        }



	}
}
