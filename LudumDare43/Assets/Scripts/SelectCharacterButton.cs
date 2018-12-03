using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterButton : MonoBehaviour {

    [SerializeField]
    private string name;

    [SerializeField]
    private GameObject buttonValid;

    private ValidSelectedCharacter scr;

    // Use this for initialization
    void Start () {

        scr = buttonValid.GetComponent<ValidSelectedCharacter>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetCharacter() { scr.SetCharacter(name); }

}
