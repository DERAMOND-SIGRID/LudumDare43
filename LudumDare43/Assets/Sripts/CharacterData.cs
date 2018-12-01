using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour {

    [SerializeField]
    private int health;

    public int GetHealth() { return health; }
    public void SetHealth(int number)
    {
        health = number;
    }

    [SerializeField]
    private int damage;

    public int GetDamage() { return damage; }

    [SerializeField]
    private float moveSpeed;

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    [SerializeField]
    private float attackFrequency;

    public float GetAttackFrequency()
    {
        return attackFrequency;
    }

    [SerializeField]
    private int attackDistance;

    public int GetAttackDistance()
    {
        return attackDistance;
    }
}
