using UnityEngine;
using System.Collections;

public class MoveBulletAndDelete : MonoBehaviour {

    // Use this for initialization
    public float speed = 0.05f;
    public GameObject explosionGO;
    void Start()
    {
        //transform.position = new Vector3(12.64f, transform.position.y, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3((float)transform.position.x + speed, (float)transform.position.y, (float)transform.position.z);
        Debug.Log("BULLET AT POS Y: " + transform.position.y + " X: " + transform.position.x);
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

   

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }


}
