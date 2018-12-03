using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour {

    [SerializeField]
    private int chastLevel;

    [SerializeField]
    private List<GameObject> contents;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        print("coffre clické");
    }

}
