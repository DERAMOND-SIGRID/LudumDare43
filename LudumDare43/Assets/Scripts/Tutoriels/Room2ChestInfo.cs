using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room2ChestInfo : MonoBehaviour {
        
    private GameObject textInfo;
    private GameObject player;
    private GameObject character;

    private GameObject canva;

    private GameObject arrow;
    public void SetArrow(GameObject sprite) { arrow = sprite; }
    GameObject instanceArrow;

    private float timer;

    // Use this for initialization
    void Start () {

        textInfo = GameObject.Find("TextPanelInfo");
        player = GameObject.Find("Player");
        character = player.GetComponentInChildren<CharacterData>().gameObject;

        canva = GameObject.Find("Canvas");

        instanceArrow = Instantiate(arrow, canva.transform);
        instanceArrow.GetComponent<RectTransform>().localPosition = new Vector3(-116, -81, 0);
        instanceArrow.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0, 0, 90);

        textInfo.GetComponent<Text>().text = "To open the chest, you will need the Picklock";

    }
	
	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (timer >= 3)
        {
            textInfo.GetComponent<Text>().text = "";

            Destroy(instanceArrow);

            player.GetComponent<PlayerMoves>().enabled = true;
            CharacterCombat[] objects = Resources.FindObjectsOfTypeAll<CharacterCombat>();
            foreach (CharacterCombat w in objects)
            {
                w.enabled = true;
            }

            GameObject ennemy = GameObject.Find("EnnemyListRoom2").GetComponentInChildren<EnnemyMoves>().gameObject;
            
            ennemy.GetComponent<EnnemyMoves>().SetCanHunt(true);            

            ennemy.GetComponent<EnnemyCombat>().SetCanAttack(true);           
            
            gameObject.GetComponent<Level1Manager>().LaunchRoom3EnnemyInfo();

            Destroy(this);

        }

    }
}
