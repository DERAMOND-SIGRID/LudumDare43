using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorCombat :  PlayerCombat {

    protected override void LeftClickAction()
    {
        
        //récupérer l'ennemi clické
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
        
        Transform[] ennemyList = GameObject.Find("EnnemyList").GetComponentsInChildren<Transform>();
        
        foreach (Transform child in ennemyList) {

            float margin = 0.5f;

            if (child.position.x - margin <= mousePosition.x && child.position.y + margin >= mousePosition.y 
                && child.position.x + margin >= mousePosition.x && child.position.y - margin <= mousePosition.y)
            {
                
                Transform theGoodOne;
                theGoodOne = child;
                
                //vérifier la distance entre le player et l'ennemi clické
                Transform papy = gameObject.GetComponent<Transform>().parent.GetComponent<Transform>();

                float distance = Mathf.Abs(Vector3.Distance(theGoodOne.position, papy.position));
                print(distance);
                //si distance <= distance d'attaque alors
                if (distance <= gameObject.GetComponentInChildren<CharacterData>().GetAttackDistance())
                {                    
                    theGoodOne.GetComponent<EnnemyCombat>().TakeDamage(gameObject.GetComponentInChildren<CharacterData>().GetDamage());
                }


            }
        }

    }

    protected override void RightClickAction()
    {
        // to do
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckMouseInput();
	}


}
