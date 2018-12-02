using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    [SerializeField]
    private GameObject level1;
    private GameObject instanceLevel1;

    private Vector3 spawnStart;

    [SerializeField]
    private GameObject player;
    private GameObject instancePlayer;

    [SerializeField]
    private GameObject warrior;
    private GameObject instanceWarrior;

    // Use this for initialization
    void Start () {

        instanceLevel1 = Instantiate(level1, new Vector3(1, -1, 0), Quaternion.identity);
        instanceLevel1.name = "Level";

        spawnStart = GameObject.Find("SpawnStart").GetComponent<Transform>().position;

        instancePlayer = Instantiate(player, spawnStart, Quaternion.identity);
        instancePlayer.name = "Player";

        instanceWarrior = Instantiate(warrior, instancePlayer.transform);
        instanceWarrior.name = "Warrior";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
