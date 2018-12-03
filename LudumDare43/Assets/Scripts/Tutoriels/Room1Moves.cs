using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room1Moves : MonoBehaviour {

    private GameObject textInfo;
    private GameObject player;

    private string redColor = "#ff0000";
    private string greenColor = "#00ff00";
    private string zColor;
    private string qColor;
    private string sColor;
    private string dColor;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");
        player = GameObject.Find("Player");

        zColor = qColor = sColor = dColor = redColor;

        textInfo.GetComponent<Text>().text = "Push <color=" + zColor + ">Z</color>" +
                                                    "<color=" + qColor + ">Q</color>" +
                                                    "<color=" + sColor + ">S</color>" +
                                                    "<color=" + dColor + ">D</color> to move up, left, down, right";

        player.GetComponent<PlayerMoves>().enabled = true;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("z")) { zColor = greenColor; }

        if (Input.GetKey("q")) { qColor = greenColor; }

        if (Input.GetKey("s")) { sColor = greenColor; }

        if (Input.GetKey("d")) { dColor = greenColor; }

        textInfo.GetComponent<Text>().text = "Push <color=" + zColor + ">Z</color>" +
                                                    "<color=" + qColor + ">Q</color>" +
                                                    "<color=" + sColor + ">S</color>" +
                                                    "<color=" + dColor + ">D</color> to move up, left, down, right";

        if (zColor == qColor && qColor == sColor && sColor == dColor && zColor == greenColor)
        {
            player.GetComponent<PlayerMoves>().enabled = false;

            textInfo.GetComponent<Text>().text = "";

            gameObject.GetComponent<Level1Manager>().LaunchRoom1DoorOpening();

            Destroy(this);
        }

    }

}
