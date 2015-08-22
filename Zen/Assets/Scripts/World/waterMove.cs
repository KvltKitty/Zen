using UnityEngine;
using System.Collections;

public class waterMove : MonoBehaviour {
	public Renderer rend;
	float curOffsetX, curOffsetY;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Standard");
		curOffsetX = 0.0f;
		curOffsetY = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		curOffsetX += 0.002f;
		curOffsetY += 0.0005f;
		if(curOffsetX >= 1.0f){
			curOffsetX = 0.0f;
		}
		if(curOffsetY >= 1.0f){
			curOffsetX = 0.0f;
		}
		rend.material.SetTextureOffset("_MainTex", new Vector2(curOffsetX, -curOffsetY));
	}
}
