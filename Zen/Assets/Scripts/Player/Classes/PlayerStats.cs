using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public float speed;
	public float acceleration;
	public GameObject curTile;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag.Equals("Tile")){
			curTile = other.gameObject;
		}
	}
}
