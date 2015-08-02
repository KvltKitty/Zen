using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {
	public PlayerInput _input;
	private PlayerPhysics _controller;
	// Use this for initialization
	void Start () {
		_input = new PlayerInput();
		_input.Reset ();
		_controller = this.GetComponent<PlayerPhysics>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		_input.horizontal = Input.GetAxisRaw ("Horizontal");
		_input.vertical = Input.GetAxisRaw ("Vertical");

		if(Input.GetButtonDown ("Jump"))
		{
			_input.a = true;
		}
		else if(Input.GetButtonUp ("Jump"))
		{
			_input.a = false;
		}
		if(Input.GetButtonDown ("Fire1"))
		{
			_input.x = true;
		}
		else if(Input.GetButtonUp ("Fire1"))
		{
			_input.x = false;
		}
		if(Input.GetButtonDown ("Fire2"))
		{
			_input.b = true;
		}
		else if(Input.GetButtonUp ("Fire2"))
		{
			_input.b = false;
		}
		if(Input.GetButtonDown ("Fire3"))
		{
			_input.y = true;
		}
		else if(Input.GetButtonUp ("Fire3"))
		{
			_input.y = false;
		}
		_controller.setForce (_input);
	}
}
