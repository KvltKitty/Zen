using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class Tile  {
	public enum tileType
	{
		Dirt,
		Grass,
		Stone,
		Water
	}
	public tileType Type;

	public abstract void Terrashift(tileType type);

	public abstract void ActionI();

	public abstract void ActionII();

	public abstract void ActionIII();
	// Use this for initialization

}
