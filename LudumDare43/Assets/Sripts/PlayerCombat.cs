using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerCombat : MonoBehaviour {

    private List<GameObject> ennemyList;

    abstract protected void LeftClickAction();

    abstract protected void RightClickAction();


    // Use this for initialization
    void Start() {
        ennemyList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            LeftClickAction();
        }
            
        else if (Input.GetMouseButtonDown(1))
        {
            RightClickAction();
        }

    

	}
    protected void InflictDamage(int number)
    {
        for(int i = 0; i < ennemyList.Count; i ++)
        {
           int damage = gameObject.GetComponent<CharacterData>().GetDamage();
            ennemyList[i].GetComponent<EnnemyCombat>().TakeDamage(damage);
        }

    }

    public void TakeDamage(int number)
    {
        int health = gameObject.GetComponent<CharacterData>().GetHealth();

        health = health - number; 

        if (health <0)
        { health = 0;
            gameObject.GetComponent<CharacterData>().SetHealth(health);

            Die(); 
        }
        else { gameObject.GetComponent<CharacterData>().SetHealth(health);
        }
    }
    private void Die()
    {

    }

}

