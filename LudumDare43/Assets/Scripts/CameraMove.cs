using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    private Vector2 fromPosition;

    [SerializeField]
    private Vector2 toPosition;

    [SerializeField]
    GameObject otherSide;

    // Use this for initialization
    void Start () {
        Camera.main.GetComponent<CameraDatas>().GetMoveSpeed();
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {       
        Camera.main.GetComponent<Transform>().position = new Vector3(toPosition.x, toPosition.y, Camera.main.GetComponent<Transform>().position.z);

        otherSide.GetComponent<CameraMove>().enabled = true;
        this.enabled = false;
    }

}
