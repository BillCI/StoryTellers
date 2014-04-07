using UnityEngine;
using System.Collections;

public class Node {
	private Story _story;
	public Story story{
		get {
			return _story;
		} 
		set {
			this._story = value;
		}
	}

	private Character _character;
	public Character character {
		get {
			return _character;
		}
		set {
			_character = value;
		}
	}

	private Wedge[] _wedges;


}
