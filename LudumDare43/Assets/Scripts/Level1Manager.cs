using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Manager : MonoBehaviour {

    private string redColor = "#ff0000";
    private string greenColor = "#00ff00";
    private string zColor;
    private string qColor;
    private string sColor;
    private string dColor;

    [SerializeField]
    private GameObject arrow;

    [SerializeField]
    private GameObject trigger;

    // Use this for initialization
    void Start () {
       
        GameObject player = GameObject.Find("Player");
        player.GetComponent<PlayerMoves>().enabled = false;

        GameObject warrior = GameObject.Find("Warrior");

        LaunchRoom1Moves();
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    private void LaunchRoom1Moves()
    {
        gameObject.AddComponent<Room1Moves>();
    }

    public void LaunchRoom1DoorOpening()
    {
        Room1DoorOpening r1do = gameObject.AddComponent<Room1DoorOpening>();
        r1do.SetArrow(arrow);
    }

    public void LaunchRoom2EnnemyInfo()
    {
        Room2EnnemyInfo r2ei = gameObject.AddComponent<Room2EnnemyInfo>();
        r2ei.SetArrow(arrow);
    }

    public void LaunchRoom2ChestInfo()
    {
        Room2ChestInfo r2ci = gameObject.AddComponent<Room2ChestInfo>();
        r2ci.SetArrow(arrow);       
    }

    public void LaunchRoom3EnnemyInfo()
    {
        Room3EnnemyInfo r3ei = gameObject.AddComponent<Room3EnnemyInfo>();
        r3ei.SetArrow(arrow);
    }

    public void LaunchRoom3ChangeCharacter()
    {
        gameObject.AddComponent<Room3ChangeCharacter>();
    }

    public void LaunchRoom4EnnemyInfo() { }

}
