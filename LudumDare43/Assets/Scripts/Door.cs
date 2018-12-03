using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    [SerializeField]
    private GameObject trigger;

    private bool thereIsTriggerOnStart;

    [SerializeField]
    private UnityEvent OnTriggerDie;

    void Start()
    {
        if (trigger != null) { thereIsTriggerOnStart = true; }
    }

    void Update()
    {
        if (thereIsTriggerOnStart == true && trigger == null)
        {
            OnTriggerDie.Invoke();
        }
    }

    public void OpenNormalDoor()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = null;
    }

}
