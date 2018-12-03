using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCombat : MonoBehaviour {

    private Vector3 playerPosition;
    private float attackTimer;
    private int damage;

    [SerializeField]
    private List<GameObject> characterCantAttack;

    private bool canAttackCharacter;

    private bool canAttack;
    public void SetCanAttack(bool canHe) { canAttack = canHe; }

    private GameObject character;
    public void SetCharacter(GameObject current) { character = current; }

    // Use this for initialization
    void Start () {

        attackTimer = 0;

        damage = gameObject.GetComponent<CharacterData>().GetDamage();

        canAttackCharacter = true;

    }
	
	// Update is called once per frame
	void Update () {
               
        playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;

        attackTimer = attackTimer + Time.deltaTime;

        if (Mathf.Abs(playerPosition.x - gameObject.GetComponent<Transform>().position.x) <= gameObject.GetComponent<CharacterData>().GetAttackDistance())
        {

            foreach (GameObject go in characterCantAttack)
            {                
                if (go.name == character.name)
                {
                    canAttackCharacter = false;
                }
            }

            if (attackTimer >= gameObject.GetComponent<CharacterData>().GetAttackFrequency()
                && character != null && canAttack == true && canAttackCharacter == true)
            {
                attackTimer = 0;
                //InflictDamage(damage);
            }
        }
        
	}

    public void InflictDamage(int number)
    {
        GameObject.Find("Player").GetComponentInChildren<PlayerCombat>().TakeDamage(number);
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

    public void Die()
    {        
        Destroy(gameObject);
    }

}
