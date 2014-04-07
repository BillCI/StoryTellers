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

	protected string _name = "Error: 602";
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
		set {
			this._parrent = value;
		}
	}
	
	protected Emotion _olderSibling;
	public Emotion olderSibling{
		get {
			return this._olderSibling;
		}
		set {
			value.yungerSibling = this;
			this._olderSibling = value;
		}
	}

	protected Emotion _yungerSibling;
	public Emotion yungerSibling{
		get {
			return this._yungerSibling;
		}
		set {
			this._yungerSibling = value;
		}
	}

	protected Emotion[] _children;
	public Emotion[] children {
		get {
			return this._children;
		}
		set {
			this._children = value;
			foreach(Emotion e in this._children) {
				e.parrent = this;
			}
		}
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
