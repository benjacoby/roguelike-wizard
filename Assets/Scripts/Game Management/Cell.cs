//using UnityEngine;
using System.Collections;

public class Cell// : MonoBehaviour 
{
	private IntVector2 position;
	//private bool isWalkable;

	public Cell (int x, int y, bool isWalkable)
	{
		position = new IntVector2 (x, y);
		isWalkable = true;
	}

	public IntVector2 POSITION
	{
		get { return position; }
	}



//	public override string ToString()
//	{
//		if (isWalkable) {
//			return ".";
//		} else 
//		{
//			return "%";
//		}
//	}
} 
