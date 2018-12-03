using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room3EnnemyInfo : MonoBehaviour {

    private GameObject textInfo;
    private GameObject player;
    private GameObject character;

    private bool alreadyExecuted1;

    private float timer;

    private GameObject canva;

    private GameObject arrow;
    public void SetArrow(GameObject sprite) { arrow = sprite; }
    GameObject instanceArrow;

    private bool alreadyExecuted2;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");

        player = GameObject.Find("Player");
        character = player.GetComponentInChildren<CharacterData>().gameObject;

        alreadyExecuted1 = false;
        alreadyExecuted2 = false;
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (alreadyExecuted1 == false && GameObject.Find("TriggerR3EI").GetComponent<CheckTrigger>().GetIsTrigger() == true && timer >= 3)
        {

            player.GetComponent<PlayerMoves>().enabled = false;

            canva = GameObject.Find("Canvas");
            instanceArrow = Instantiate(arrow, canva.transform);
            instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(136, 0, 0);

            textInfo.GetComponent<Text>().text = "Only the level 1 archer is immune to this enemy. Fight this enemy by getting little less closer than the other and click on the left mouse button";

            alreadyExecuted1 = true;
            timer = 0;

        }

        if (alreadyExecuted1 == true && alreadyExecuted2 == false && timer >= 3)
        {

            Destroy(instanceArrow);

            textInfo.GetComponent<Text>().text = "Then your are going to die ...";

            alreadyExecuted2 = true;
            timer = 0;

        }

        if (alreadyExecuted2 == true && timer >= 3)
        {
            textInfo.GetComponent<Text>().text = "";

            player.GetComponent<PlayerMoves>().enabled = true;
            CharacterCombat[] objects = Resources.FindObjectsOfTypeAll<CharacterCombat>();
            foreach (CharacterCombat w in objects)
            {
                w.enabled = true;
            }

            GameObject ennemy = GameObject.Find("EnnemyListRoom3").GetComponentInChildren<EnnemyMoves>().gameObject;

            ennemy.GetComponent<EnnemyMoves>().SetCanHunt(true);            

            ennemy.GetComponent<EnnemyCombat>().SetCanAttack(true);

            gameObject.GetComponent<Level1Manager>().LaunchRoom3ChangeCharacter();

            Destroy(this);

        }

    }

}
