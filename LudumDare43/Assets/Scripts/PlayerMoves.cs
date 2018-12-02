using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    private float moveSpeed;

    private Rigidbody2D rigidbody;
    private Vector2 moveDirection;

    // Use this for initialization
    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.GetComponent<Transform>().childCount > 0)
        {
            moveSpeed = gameObject.GetComponentInChildren<CharacterData>().GetMoveSpeed();
        }
        else
        {
            moveSpeed = 0;
        }

        if (Input.GetKey("z"))
        {
            //gameObject.GetComponent<Transform>().Translate(Vector3.up *moveSpeed);
            moveDirection = Vector2.up;
        }

        if (Input.GetKey("s"))
        {
            //gameObject.GetComponent<Transform>().Translate(Vector3.down *moveSpeed);
            moveDirection = Vector2.down;
        }

        if (Input.GetKey("q"))
        {
            //gameObject.GetComponent<Transform>().Translate(Vector3.left *moveSpeed);
            moveDirection = Vector2.left;
        }

        if (Input.GetKey("d"))
        {
            //gameObject.GetComponent<Transform>().Translate(Vector3.right *moveSpeed);
            moveDirection = Vector2.right;
        }

        if(!Input.anyKey)
        {
            moveDirection = new Vector2(0, 0);
        }
                
        rigidbody.MovePosition(rigidbody.position + moveDirection * moveSpeed * Time.deltaTime);

    }
}


