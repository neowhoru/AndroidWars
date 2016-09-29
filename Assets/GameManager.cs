using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject spawner;
    public Text scoreLabel;
    public Text pressPlayLabel;

    public uint score = 0;
    private bool isGameStarted = false;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && isGameStarted==false)
        {
            isGameStarted = true;
            pressPlayLabel.enabled = false;
            this.player.GetComponent<PlayerControllerScript>().isGameStarted = true;
            this.spawner.GetComponent<ObjectSpawner>().isGameStarted = true;
        }
        scoreLabel.text = "DEAD APPLES: " + score.ToString();

    }
}
