using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room2EnnemyInfo : MonoBehaviour {
        
    private GameObject textInfo;
    private GameObject player;
    private GameObject character;

    private bool alreadyExecuted;

    private GameObject canva;

    private GameObject arrow;
    public void SetArrow(GameObject sprite) { arrow = sprite; }
    GameObject instanceArrow;

    private float timer;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");

        player = GameObject.Find("Player");
        player.GetComponent<PlayerMoves>().enabled = true;

        character = player.GetComponentInChildren<CharacterData>().gameObject;

        alreadyExecuted = false;
        timer = 0;

    }
	
	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (alreadyExecuted == false && GameObject.Find("TriggerR2EI").GetComponent<CheckTrigger>().GetIsTrigger() == true && timer >= 3)
        {

            player.GetComponent<PlayerMoves>().enabled = false;

            canva = GameObject.Find("Canvas");
            instanceArrow = Instantiate(arrow, canva.transform);
            instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(126, 0, 0);

            textInfo.GetComponent<Text>().text = "Only the level 1 warrior is immune to this enemy. Fight this enemy by getting closer and click on the left mouse button";

            alreadyExecuted = true;
            timer = 0;
        }

        if (alreadyExecuted == true && timer >= 3)
        {

            Destroy(instanceArrow);

            gameObject.GetComponent<Level1Manager>().LaunchRoom2ChestInfo();

            Destroy(this);

        }

	}

}
