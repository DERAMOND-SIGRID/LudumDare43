using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OpenNormalDoor()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = null;
    }

}
