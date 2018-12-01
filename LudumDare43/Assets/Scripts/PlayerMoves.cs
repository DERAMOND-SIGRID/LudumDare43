using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    private float moveSpeed; 

	// Use this for initialization
	void Start () {
		
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
        { gameObject.GetComponent<Transform>().Translate(Vector3.up *moveSpeed);
        }

        if (Input.GetKey("s"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.down *moveSpeed);
        }

        if (Input.GetKey("q"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.left *moveSpeed);
        }

        if (Input.GetKey("d"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.right *moveSpeed);
        }
    }
}


