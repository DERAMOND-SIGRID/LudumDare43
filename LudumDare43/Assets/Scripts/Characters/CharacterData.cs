using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour {

    private bool isAlive;
    public void SetIsAlive(bool isHe) { isAlive = isHe; }

    [SerializeField]
    private float moveSpeed;

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
        
    [SerializeField]
    private int attackDistance;

    public int GetAttackDistance()
    {
        return attackDistance;
    }

    [SerializeField]
    protected List<GameObject> ennemyCharacterCantAttack;

    public List<GameObject> GetEnnemyCharacterCantAttack() { return ennemyCharacterCantAttack; }

    private void Start()
    {
        isAlive = true;
    }

}
