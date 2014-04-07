using UnityEngine;
using System.Collections;

public class Story  {

	private Node[] _nodes;
	public Node[] nodes {
		get {
			if (_nodes == null){
				_nodes = new Node[NUMBERS.arrayBlockSize];
			}
			return nodes;
		}
		set {
			_nodes = value;
		}
	}

	private Character[] _characters;
	public Character[] characters {
		get {
			if(_characters == null){
				_characters = new Character[NUMBERS.arrayBlockSize];
			}
			return _characters;
		}
		set {
			_characters = value;
		}
	}
}
