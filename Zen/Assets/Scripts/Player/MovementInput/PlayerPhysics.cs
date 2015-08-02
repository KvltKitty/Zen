using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {
	float horizontalForce, verticalForce;
	Vector3 velocity;
	public float speed;
	Transform viewTarget;
	// Use this for initialization
	void Start () 
	{
		velocity = new Vector3(0.0f, 0.0f, 0.0f);

	}

	void LateUpdate()
	{
		velocity.Normalize ();
		velocity *= speed;
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
			Debug.Log (newRotation.y);
			transform.rotation = Quaternion.Euler (newRotation);
		}

	}
}
