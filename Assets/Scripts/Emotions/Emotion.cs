using UnityEngine;
using System.Collections;

public class Emotion {

	protected int _level;
	public int level {
		get {
			return this._level;
		}
		set {}
	}

	protected string _name;
	public string name {
		get {
			return this._name;
		}
		set {}
	}
	
	protected Emotion _parrent;
	public Emotion parrent{
		get {
			return this._parrent;
		}
		set {}
	}
	
	protected Emotion _olderSibling;
	public Emotion olderSibling{
		get {
			return this._olderSibling;
		}
		set {}
	}

	protected Emotion _yungerSibling;
	public Emotion yungerSibling{
		get {
			return this._yungerSibling;
		}
		set {}
	}

	protected Emotion[] _children;
	public Emotion[] children {
		get {
			return this._children;
		}
		set {}
	}

	protected float _fillTime = NUMBERS.defaultEmotionFillTime;
	public float fillTime{
		get {
			return this._fillTime;
		}
		set {}
	}

	protected float _switchTime = NUMBERS.defaultEmotionTransferTime;
	public float switchTime {
		get {
			return this._switchTime;
		}
		set {}
	}
}
