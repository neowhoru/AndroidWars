using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{

    // Use this for initialization
    private float timeElapsed = 0;
    public GameObject prefabEnemy;
    private Random rand;
    public bool isGameStarted = false;
    public bool isGameOver = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameStarted && !isGameOver)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= 2.0f)
            {
                timeElapsed = 0;
                prefabEnemy.transform.position = new Vector3(prefabEnemy.transform.position.x, Random.Range(-1.70f, 4.0f), prefabEnemy.transform.position.z);
                Instantiate(prefabEnemy);

            }
        }
        
    }
}
