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
	}
}
