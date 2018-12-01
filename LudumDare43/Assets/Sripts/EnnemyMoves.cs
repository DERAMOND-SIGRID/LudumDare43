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

        gameObject.GetComponent<Transform>().position = Vector3.MoveTowards(gameObject.GetComponent<Transform>().position, playerPosition, moveSpeed);
	}
}
