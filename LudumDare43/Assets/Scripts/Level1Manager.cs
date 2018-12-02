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

    // Use this for initialization
    void Start () {

        GameObject player = GameObject.Find("Player");
        player.GetComponent<PlayerMoves>().enabled = false;

        GameObject warrior = GameObject.Find("Warrior");
        warrior.GetComponent<WarriorCombat>().enabled = false;
                
        LaunchTutoPart1();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LaunchTutoPart1()
    {
        TutorielPart1 tutoPart1 = gameObject.AddComponent<TutorielPart1>();
    }

    public void LaunchTutoPart2()
    {
        TutorielPart2 tutoPart2 = gameObject.AddComponent<TutorielPart2>();
        tutoPart2.SetArrowSprite(arrow);
    }

    public void LaunchTutoPart3()
    {
        TutorielPart3 tutoPart3 = gameObject.AddComponent<TutorielPart3>();        
    }

}
