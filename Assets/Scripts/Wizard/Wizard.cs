using UnityEngine;
using System.Collections;

public class Wizard : MonoBehaviour {

	private Alignment alignment;
	private Weapon weapon;
	private Amulet amulet;
	private Spell[] spells;

	public Wizard (Alignment _alignment, Weapon _weapon, Amulet _amulet, Spell[] _spells)
	{
		alignment = _alignment;

		weapon = _weapon;
		amulet = _amulet;
		spells = _spells;
	}

	void Awake ()
	{
		alignment = new Alignment (Alignment.Value.Elder);
	}

	void Start () {
		PrintDebugging ();
	}
		
	void PrintDebugging ()
	{
		Debug.Log ("Alignment: " + alignment.Get());
		Debug.Log ("Weapon: "+ amulet);
		Debug.Log ("Amulet: "+ amulet);
		Debug.Log ("Spells: "+ spells);
	}

}
