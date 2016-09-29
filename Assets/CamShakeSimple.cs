using UnityEngine;
using System.Collections;

public class CamShakeSimple : MonoBehaviour {

    Vector3 originalCameraPosition;

    float shakeAmt = 0;

    public Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        originalCameraPosition = mainCamera.transform.position;
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "enemy")
        {
            Debug.Log("COLLIDER 2D SHAKER");
            //shakeAmt = coll.relativeVelocity.magnitude * .0025f;
            shakeAmt = 0.25f;
            InvokeRepeating("CameraShake", 0, .01f);
            Invoke("StopShaking", 0.3f);
        }


    }

    void CameraShake()
    {
        if (shakeAmt > 0)
        {
            float quakeAmt = Random.value * shakeAmt * 2 - shakeAmt;
            Vector3 pp = mainCamera.transform.position;
            pp.y += quakeAmt; // can also add to x and/or z
            mainCamera.transform.position = pp;
        }
    }

    void StopShaking()
    {
        CancelInvoke("CameraShake");
        mainCamera.transform.position = originalCameraPosition;
        Destroy(gameObject);
    }
}
