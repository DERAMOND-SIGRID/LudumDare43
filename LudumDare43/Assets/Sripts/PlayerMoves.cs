using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey("z"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.up);
        }

        if (Input.GetKey("s"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.down);
        }

        if (Input.GetKey("q"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.left);
        }

        if (Input.GetKey("d"))
        { gameObject.GetComponent<Transform>().Translate(Vector3.right);
        }
    }
}


