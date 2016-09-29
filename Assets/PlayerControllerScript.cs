using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public bool isGameStarted = false;
    public bool isGameOver = false;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        if(isGameOver==false && isGameStarted == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                Vector3 position = this.transform.position;
                position.y = gameObject.transform.position.y + 0.05f;
                gameObject.transform.position = position;
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                Vector3 position = this.transform.position;
                position.y = gameObject.transform.position.y - 0.05f;
                
                gameObject.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                // ToDo: Instanciate a Rocket Prefab
                GameObject theInstance = Instantiate(bulletPrefab);
                gameObject.GetComponent<AudioSource>().Play(0);
                theInstance.transform.position = gameObject.transform.position;

            }
        }
        

    }
}
