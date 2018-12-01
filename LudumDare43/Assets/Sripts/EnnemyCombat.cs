using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCombat : MonoBehaviour {

    private Vector3 playerPosition;
    private float attackTimer;
    private int damage;

	// Use this for initialization
	void Start () {

        attackTimer = 0;

        damage = gameObject.GetComponent<CharacterData>().GetDamage();

	}
	
	// Update is called once per frame
	void Update () {
               
        playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;

        attackTimer = attackTimer + Time.deltaTime;

        if (Mathf.Abs(playerPosition.x - gameObject.GetComponent<Transform>().position.x) <= gameObject.GetComponent<CharacterData>().GetAttackDistance())
        {
           
            if (attackTimer >= gameObject.GetComponent<CharacterData>().GetAttackFrequency())
            {
                attackTimer = 0;
                InflictDamage(damage);
            }
        }
        
	}

    protected void InflictDamage(int number)
    {
        GameObject.Find("Player").GetComponent<PlayerCombat>().TakeDamage(number);
    }

    public void TakeDamage(int number)
    {
        int health = gameObject.GetComponent<CharacterData>().GetHealth();

        health = health - number;

        if (health < 0)
        {
            health = 0;
            gameObject.GetComponent<CharacterData>().SetHealth(health);
            Die();
        }
        else
        {
            gameObject.GetComponent<CharacterData>().SetHealth(health);
        }
        
    }

    private void Die() { }

}
