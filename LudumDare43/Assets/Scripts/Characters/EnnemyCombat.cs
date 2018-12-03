using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCombat : MonoBehaviour {

    private Vector3 playerPosition;
    private float attackTimer;    
    
    private List<GameObject> characterCantAttack;

    private bool canAttackCharacter;

    [SerializeField]
    private bool canAttack;
    public void SetCanAttack(bool canHe) { canAttack = canHe; }

    private GameObject character;    

    // Use this for initialization
    void Start () {

        attackTimer = 0;

        characterCantAttack = gameObject.GetComponent<CharacterData>().GetEnnemyCharacterCantAttack();
        
        canAttackCharacter = true;

        character = GameObject.Find("Player").GetComponentInChildren<CharacterData>().gameObject;

    }
	
	// Update is called once per frame
	void Update () {
        
        playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;

        attackTimer = attackTimer + Time.deltaTime;

        // if distance between player and ennemy <= attack distance
        if (Mathf.Abs(playerPosition.x - gameObject.GetComponent<Transform>().position.x) <= gameObject.GetComponent<CharacterData>().GetAttackDistance())
        {

            if (character != null) {

                character = GameObject.Find("Player").GetComponentInChildren<CharacterData>().gameObject;

                foreach (GameObject go in characterCantAttack)
                {                   
                    if (go.name == character.name)
                    {
                        canAttackCharacter = false;
                    }
                }

                if (canAttack == true && canAttackCharacter == true)
                {
                    character.GetComponent<CharacterData>().SetIsAlive(false);
                    
                    Destroy(character);
                }

            }

        }
        
	}

    public void Die()
    {        
        Destroy(gameObject);
    }

    public void OnMouseDown()
    {
        // if player distance attaque is ok        
        if (Mathf.Abs(playerPosition.x - gameObject.GetComponent<Transform>().position.x) <= GameObject.Find("Player").GetComponentInChildren<CharacterData>().GetAttackDistance())
        {
            bool canAttack = true;

            // if player can attack ennemy
            foreach (GameObject go in GameObject.Find("Player").GetComponentInChildren<CharacterData>().GetEnnemyCharacterCantAttack())
            {
                if (go.name == gameObject.name)
                {
                    canAttack = false;
                }
            }

            if (canAttack == true)
            {
                Die();
            }
          
        }

    }

}
