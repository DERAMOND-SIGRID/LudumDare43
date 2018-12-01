using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour {

    [SerializeField]
    private int health;

    [SerializeField]
    private int damage;

    [SerializeField]
    private float moveSpeed;

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

}
