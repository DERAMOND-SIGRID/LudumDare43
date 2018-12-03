using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room3ChangeCharacter : MonoBehaviour {

    private GameObject textInfo;
    private GameObject player;

    private bool alreadyExecute1;
  
    private float timer;

    private GameManager gm;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");

        player = GameObject.Find("Player");

        alreadyExecute1 = false;
       
        timer = 0;

        gm = Camera.main.GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (GameObject.Find("Player").GetComponentInChildren<CharacterData>() == null && alreadyExecute1 == false && timer >= 4)
        {
            textInfo.GetComponent<Text>().text = "You are dead!";

            alreadyExecute1 = true;
            timer = 0;
        }

        if (alreadyExecute1 = true && timer >=4)
        {
            textInfo.GetComponent<Text>().text = "You must now choose a new character :";

            gm.ShowMenuSelection();
            GameObject.Find("ButtonSelectWarrior").GetComponent<Button>().interactable = false;
            GameObject.Find("ButtonSelectPicklock").GetComponent<Button>().interactable = false;

            gameObject.GetComponent<Level1Manager>().LaunchRoom4EnnemyInfo();

            Destroy(this);
        }

	}
}
