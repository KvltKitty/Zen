using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public float speed;
	public float acceleration;
	public GameObject curTile;
	public Transform particleTile;



	// Use this for initialization
	void Start () {

		particleTile = GameObject.Find("curTileEffect").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag.Equals("Tile")){
			curTile = other.gameObject;
			Vector3 particlePosition = curTile.transform.position;
			particlePosition.y += 1.0f;
			particleTile.position = particlePosition;
		}
	}
}
