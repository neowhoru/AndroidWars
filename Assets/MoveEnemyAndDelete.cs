using UnityEngine;
using System.Collections;

public class MoveEnemyAndDelete : MonoBehaviour
{

    // Use this for initialization
    public float speed = 0.05f;
    public GameObject explosionGO;
    public bool hit = false;
    void Start()
    {
        speed = Random.Range(0.05f, 0.15f);
        transform.position = new Vector3(12.64f, transform.position.y, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(hit == false)
        {
            if (transform.position.x > -10)
            {
                transform.position = new Vector3((float)transform.position.x - speed, (float)transform.position.y, (float)transform.position.z);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject manager = GameObject.FindGameObjectWithTag("GameManager");
        Debug.Log("Collider Enemy OnTriggerEnter2d " + other.name);
        if (other.tag == "bullet")
        {
            hit = true;
            manager.GetComponent<GameManager>().score++;
            GameObject explosion = Instantiate(explosionGO);
            explosion.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
    }
}
