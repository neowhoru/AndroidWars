using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

    public string currentScene = "Title";
    public string nextNameTheme = "SpaceGameScene";
    public 
	// Use this for initialization
	void Start () {
	    
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            Debug.Log("Space key was pressed.");
            SceneManager.LoadScene(nextNameTheme, LoadSceneMode.Single);
        }
    }
}
