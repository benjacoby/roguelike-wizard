using System.Collections;

public struct Alignment {

	public enum Value 
	{ 
		//value A
		Chaotic,		//Entropy, Chaos, disorder, oneness, emotion, LOVE (red / black)
		//---->
		Multiversal,	//Constantly moves through the multiverse, altering his timeline and his opponents, pulling in alternate versions of the player/target
		Elder,			//Someone who has seen beyond the void of the multiverse -- the eldritch rulers of what lies beyond the understandable universe. 

		//value B
		Growth,			//Order, syntropy, (matter seeking consciousness), dispassion, WISDOM (green/blue)
		//---->
		Radiant, 		// wonder, emotional sculpting of the universe, wild powers (green)
		Quantum, 		// zen-like understanding of the fabric of the universe, precision (blue)

	}

	private Value value;

	public Alignment(Value _value)
	{
		value = _value;
	}

	#region PUBLIC HELPER FUNCTIONS

	public void Set (Value _value)
	{
		value = _value;
	}
		
	public Value Get ()
	{
		return value;
	}

	#endregion

}
