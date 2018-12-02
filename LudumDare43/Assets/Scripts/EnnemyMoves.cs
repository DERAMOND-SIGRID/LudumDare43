using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMoves : MonoBehaviour {

    private Vector3 playerPosition;

    private float moveSpeed;

	// Use this for initialization
	void Start () {

        moveSpeed = gameObject.GetComponent<CharacterData>().GetMoveSpeed();
    
	}
	
	// Update is called once per frame
	void Update () {

        playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;

        float distanceX = Mathf.Abs(gameObject.GetComponent<Transform>().position.x - playerPosition.x);
        float distanceY = Mathf.Abs(gameObject.GetComponent<Transform>().position.y - playerPosition.y);
        float distanceAttack = gameObject.GetComponentInChildren<CharacterData>().GetAttackDistance();

        float x;
        float y;

        if (distanceX != 0)
        {
            x = (distanceAttack / distanceX) * (gameObject.GetComponent<Transform>().position.x - playerPosition.x) + playerPosition.x;
        }
        else
        {
            x = 0;
        }

        if(distanceY != 0)
        {
            y = (distanceAttack / distanceY) * (gameObject.GetComponent<Transform>().position.y - playerPosition.y) + playerPosition.y;
        }
        else
        {
            y = 0;
        }
               
        gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(gameObject.GetComponent<Transform>().position, new Vector3(x,y,0), moveSpeed);
    }
}
