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

    private TutorielPart3 tutoPart3;

    [SerializeField]
    private GameObject ennemy1;
    private GameObject instanceEnnemyNum1;

    [SerializeField]
    private GameObject trigger;

    // Use this for initialization
    void Start () {

        instanceEnnemyNum1 = Instantiate(ennemy1, new Vector3(20, 0, 0), Quaternion.identity, GameObject.Find("EnnemyList").GetComponent<Transform>());

        GameObject player = GameObject.Find("Player");
        player.GetComponent<PlayerMoves>().enabled = false;

        GameObject warrior = GameObject.Find("Warrior");
        warrior.GetComponent<WarriorCombat>().enabled = false;
                
        LaunchTutoPart1();
    }
	
	// Update is called once per frame
	void Update () {
        if (tutoPart3 != null)
        {
            tutoPart3.SetCanContinue(trigger.GetComponent<CheckLaunchingTutoPart3>().GetIsTrigger());
        }
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
        tutoPart3 = gameObject.AddComponent<TutorielPart3>();
        tutoPart3.SetArrowSprite(arrow);
        tutoPart3.SetEnnemyNum1(instanceEnnemyNum1);
    }

    public void LaunchTutoPart4()
    {
        TutorielPart4 tutoPart4 = gameObject.AddComponent<TutorielPart4>();       
    }

}
