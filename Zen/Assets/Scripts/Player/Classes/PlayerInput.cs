using UnityEngine;
using System.Collections;

public class PlayerInput {
	public float horizontal, vertical;
	public bool a, b, x, y;

	public void Reset()
	{
		horizontal = vertical = 0.0f;
		a = b = x = y = false;
	}

}
