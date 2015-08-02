using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {
	float horizontalForce, verticalForce;
	Vector3 velocity;

	Transform viewTarget;
	private PlayerStats _stats;
	// Use this for initialization
	void Start () 
	{
		velocity = new Vector3(0.0f, 0.0f, 0.0f);
		_stats = transform.GetComponent<PlayerStats>();
	}

	void LateUpdate()
	{
		velocity.Normalize ();
		velocity *= _stats.speed;
		Move (velocity * Time.deltaTime);
	}
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void setForce(PlayerInput input)
	{
		velocity.x = input.horizontal;
		velocity.z = input.vertical;
	}

	public void Move(Vector3 deltaMovement){



		transform.Translate (deltaMovement, Space.World);
		if(Mathf.Abs (deltaMovement.x) > 0.0f || Mathf.Abs (deltaMovement.z) > 0.0f){
			Vector3 newRotation = new Vector3(0.0f, (Mathf.Atan2(deltaMovement.x, deltaMovement.z)) * 180/Mathf.PI, 0.0f);
			transform.rotation = Quaternion.Euler (newRotation);
		}

	}
}
