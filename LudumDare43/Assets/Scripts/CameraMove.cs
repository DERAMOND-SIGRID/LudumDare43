using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    private Vector2 fromPosition;

    [SerializeField]
    private Vector2 toPosition;

    private float moveSpeed;

    // Use this for initialization
    void Start () {
        Camera.main.GetComponent<CameraDatas>().GetMoveSpeed();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        Camera.main.GetComponent<Transform>().Translate(Vector3.MoveTowards(Camera.main.GetComponent<Transform>().position, new Vector3(toPosition.x, toPosition.y, Camera.main.GetComponent<Transform>().position.z), moveSpeed));
    }

}
