using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject menuSelection;
    private GameObject instancemenuSelection;    

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

    [SerializeField]
    private GameObject archer;
    private GameObject instanceArcher;

    [SerializeField]
    private GameObject picklock;
    private GameObject instancePicklock;

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

    public void InstantiateNewWarrior()
    {
        Camera.main.GetComponent<Transform>().position = new Vector3(0, 0, Camera.main.GetComponent<Transform>().position.z);

        instancePlayer.GetComponent<Transform>().position = spawnStart;

        instanceWarrior = Instantiate(warrior, instancePlayer.transform);        
        instanceWarrior.name = "Warrior";
    }

    public void InstantiateNewArcher()
    {
        Camera.main.GetComponent<Transform>().position = new Vector3(0, 0, Camera.main.GetComponent<Transform>().position.z);

        instancePlayer.GetComponent<Transform>().position = spawnStart;

        instanceArcher = Instantiate(archer, instancePlayer.transform);
        instanceArcher.name = "Archer";
    }

    public void InstantiateNewPicklock()
    {
        Camera.main.GetComponent<Transform>().position = new Vector3(0, 0, Camera.main.GetComponent<Transform>().position.z);

        instancePlayer.GetComponent<Transform>().position = spawnStart;

        instanceArcher = Instantiate(picklock, instancePlayer.transform);
        instanceArcher.name = "Picklock";
    }

    public void ShowMenuSelection()
    {
        instancemenuSelection = Instantiate(menuSelection, GameObject.Find("Canvas").transform);
    }

    public void DestroyMenuSelection()
    {
        Destroy(instancemenuSelection);
    }

}
