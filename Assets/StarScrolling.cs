using UnityEngine;
using System.Collections;

public class StarScrolling : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.y += Time.deltaTime / 10.0f;
        mat.mainTextureOffset = offset;
	
	}
}
