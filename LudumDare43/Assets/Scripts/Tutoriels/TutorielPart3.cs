using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorielPart3 : MonoBehaviour {

    private GameObject canva;
    private GameObject textInfo;

    private GameObject player;
    private GameObject character;

    private GameObject ennemyNum1;
    public void SetEnnemyNum1(GameObject ennemy) { ennemyNum1 = ennemy; }

    private bool canContinue;
    public void SetCanContinue(bool can) { canContinue = can; }

    private bool alreadyExecuted;

    private GameObject arrow;
    public void SetArrowSprite(GameObject sprite) { arrow = sprite; }

    GameObject instanceArrow;

    private float timer;

    private bool canContinue2;
    private bool canContinue3;

    // Use this for initialization
    void Start () {
        textInfo = GameObject.Find("TextPanelInfo");
        player = GameObject.Find("Player");
        character = player.GetComponentInChildren<CharacterData>().gameObject;

        player.GetComponent<PlayerMoves>().enabled = true;

        alreadyExecuted = false;
        timer = 0;

        canContinue2 = false;
        canContinue3 = false;
    }
	
	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (canContinue == true && alreadyExecuted == false)
        {
            player.GetComponent<PlayerMoves>().enabled = false;

            canva = GameObject.Find("Canvas");
            instanceArrow = Instantiate(arrow, canva.transform);
            instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(126, 0, 0);

            textInfo.GetComponent<Text>().text = "Only the level 1 warrior is immune to this enemy";

            alreadyExecuted = true;
            timer = 0;
        }

        if (canContinue == true && canContinue2 == false && canContinue3 == false && alreadyExecuted == true && timer >= 3)
        {           
            Destroy(instanceArrow);

            textInfo.GetComponent<Text>().text = "Fight this enemy by getting closer and click on the left mouse button";
            
            canContinue2 = true;
            timer = 0;
        }

        if (canContinue2 == true && canContinue3 == false && timer >= 3)
        {
            textInfo.GetComponent<Text>().text = "";

            player.GetComponent<PlayerMoves>().enabled = true;
            WarriorCombat[] objects = Resources.FindObjectsOfTypeAll<WarriorCombat>();
            foreach (WarriorCombat w in objects)
            {
                w.enabled = true;
            }

            ennemyNum1.GetComponent<EnnemyMoves>().SetCanHunt(true);
            ennemyNum1.GetComponent<EnnemyMoves>().SetCharacter(character);

            ennemyNum1.GetComponent<EnnemyCombat>().SetCanAttack(true);
            ennemyNum1.GetComponent<EnnemyCombat>().SetCharacter(character);

            canContinue3 = true;
        }

        if (canContinue3 == true && ennemyNum1 == null)
        {
            player.GetComponent<PlayerMoves>().enabled = false;
            player.GetComponentInChildren<WarriorCombat>().enabled = false;

            instanceArrow = Instantiate(arrow, canva.transform);
            instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(-126, -81, 0);

            textInfo.GetComponent<Text>().text = "To open the chest, you will need the Picklock";

            gameObject.GetComponent<Level1Manager>().LaunchTutoPart4();

            Destroy(this);
        }

    }
}
