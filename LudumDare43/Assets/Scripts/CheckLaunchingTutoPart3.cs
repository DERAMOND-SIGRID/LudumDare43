using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLaunchingTutoPart3 : MonoBehaviour {

    private bool isTrigger;
    public bool GetIsTrigger() { return isTrigger; }

	// Use this for initialization
	void Start () {
        isTrigger = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {       
        isTrigger = true;

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
    
}
