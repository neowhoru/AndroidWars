using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniRx;

public class SpawnRandomBlocks : MonoBehaviour {

    public GameObject LBlockPrefab;
    public GameObject LBlockReversedPrefab;
    public GameObject ZBlockPrefab;
    public GameObject ZBlockReversedPrefab;
    public GameObject LongBlockPrefab;
    public GameObject FourBlockPrefab;
    // Use this for initialization
    public bool isGameRunning = false;
    public IntReactiveProperty score = new IntReactiveProperty(0);
    public Text scoreText;

    void Start () {
        score.SubscribeToText(scoreText);

        score.Subscribe(_ => LeanTween.scale(scoreText.gameObject, Vector3.one, 0.2f).setFrom(Vector3.one * 0.5f).setEase(LeanTweenType.easeOutBack));
    }
	
	// Update is called once per frame
	void Update () {
        if (!isGameRunning && Input.GetMouseButtonDown(0))
        {
            isGameRunning = true;
            InvokeRepeating("spawnRandomBlock",1.0f,2.0f);

        }
    }

    void spawnRandomBlock()
    {
        score.Value++;
        int randomBlock = Random.Range(0, 5);

        GameObject theBlock;
        switch (randomBlock)
        {
            case 0:
                theBlock = Instantiate(LBlockPrefab);
                break;
            case 1:
                theBlock = Instantiate(LBlockReversedPrefab);
                break;
            case 2:
                theBlock = Instantiate(ZBlockPrefab);
                break;
            case 3:
                theBlock = Instantiate(ZBlockReversedPrefab);
                break;
            case 4:
                theBlock = Instantiate(LBlockPrefab);
                break;
            case 5:
                theBlock = Instantiate(FourBlockPrefab);
                break;


        }
    }
}
