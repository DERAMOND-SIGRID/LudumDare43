﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room1DoorOpening : MonoBehaviour {

    private GameObject textInfo;
    private GameObject player;

    private GameObject arrow;
    public void SetArrow(GameObject sprite) { arrow = sprite; }
    private GameObject instanceArrow;

    private float timer;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");
        player = GameObject.Find("Player");

        // zoom in on the door that opens
        GameObject canva = GameObject.Find("Canvas");
        instanceArrow = Instantiate(arrow, canva.transform);
        instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(211, -29, 0);

        textInfo.GetComponent<Text>().text = "Clean a closed room to be able to get out";

        timer = 0;

    }
	
	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (timer >= 3)
        {
            GameObject.Find("OpeningDoorStart").GetComponent<Door>().OpenNormalDoor();

            textInfo.GetComponent<Text>().text = "";
            Destroy(instanceArrow);

            gameObject.GetComponent<Level1Manager>().LaunchRoom2EnnemyInfo();

            Destroy(this);
        }

    }

}
