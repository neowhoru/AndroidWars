using UnityEngine;
using System.Collections;

public class MoveTetrisBlockAndCollide : MonoBehaviour {

    public float speed = 0.5f;
    private bool isMoveableByUser = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    if (isMoveableByUser)
	    {

	        if (Input.GetKeyDown(KeyCode.RightArrow))
	        {
	            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
	        }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y , transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("LEFT ROTATE");

               
                transform.Rotate(Vector3.forward * -90);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("RIGHT ROTATE");
                transform.Rotate(Vector3.forward * 90);
            }
        }
	    
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground" || coll.gameObject.tag == "block")
        {
            isMoveableByUser = false;
        }
            

    }
}
