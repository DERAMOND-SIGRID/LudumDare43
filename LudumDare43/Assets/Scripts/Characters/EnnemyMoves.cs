using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMoves : MonoBehaviour {

    private Vector3 playerPosition;

    [SerializeField]
    private bool canHunt;
    public void SetCanHunt(bool canHe) { canHunt = canHe; }

    private GameObject character;

    private List<GameObject> characterCantAttack;

    private float moveSpeed;
    
    // Use this for initialization
    void Start () {

        characterCantAttack = gameObject.GetComponent<CharacterData>().GetEnnemyCharacterCantAttack();

        moveSpeed = gameObject.GetComponent<CharacterData>().GetMoveSpeed();

    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Player").GetComponentInChildren<CharacterData>() != null)
        {

            character = GameObject.Find("Player").GetComponentInChildren<CharacterData>().gameObject;
           
            playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;

            float x;
            float y;

            bool characterAllowedToHunt = true;

            foreach (GameObject go in characterCantAttack)
            {
                if (go.name == character.name)
                {
                    characterAllowedToHunt = false;
                }
            }

            if (canHunt == true && character != null && characterAllowedToHunt == true)
            {

                float distanceX = Mathf.Abs(gameObject.GetComponent<Transform>().position.x - playerPosition.x);
                float distanceY = Mathf.Abs(gameObject.GetComponent<Transform>().position.y - playerPosition.y);
                float distanceAttack = gameObject.GetComponentInChildren<CharacterData>().GetAttackDistance();

                if (distanceX != 0)
                {
                    x = (distanceAttack / distanceX) * (gameObject.GetComponent<Transform>().position.x - playerPosition.x) + playerPosition.x;
                }
                else
                {
                    x = 0;
                }

                if (distanceY != 0)
                {
                    y = (distanceAttack / distanceY) * (gameObject.GetComponent<Transform>().position.y - playerPosition.y) + playerPosition.y;
                }
                else
                {
                    y = 0;
                }

                gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(gameObject.GetComponent<Transform>().position, new Vector3(x, y, 0), moveSpeed);

            }

        }
        
    }
}
