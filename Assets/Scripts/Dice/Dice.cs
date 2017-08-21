using UnityEngine;
using System.Collections;

public class Dice: MonoBehaviour 
{

	private int sides;

	public Dice (int _sides)
	{
		sides = _sides;
	}

	public static int Roll (int _sides)
	{
		int roll = Random.Range (0, _sides + 1);
		return roll;
	}
}
