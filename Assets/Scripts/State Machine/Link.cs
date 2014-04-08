using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Link  {
	private StreamReader _reader;
	private string _belowTheLine;
	private string _aboveTheLine;
	private float _lastCharacterMove = 0.0f;
	public bool atTheEndOfLink {
		get {
			return this._belowTheLine.Length <= 0;
		} set {}
	}

	public string displayedText {
		get {
			if(this._belowTheLine.Length > 0 && Time.realtimeSinceStartup - this._lastCharacterMove > GLOBALS.textScrollSpeed){
				this._aboveTheLine += this._belowTheLine[0];
				this._belowTheLine = this._belowTheLine.Remove(0,1);
				this._lastCharacterMove = Time.realtimeSinceStartup;
			}
			return this._aboveTheLine;
		}
		set{}
	}

	public Link(string fileName){
		// read from filename
		var sr = new StreamReader(Application.dataPath + "/" + fileName);
		this._belowTheLine = sr.ReadToEnd();
		sr.Close();

	}

	public static Rect rect {
		get {
			return new Rect((Screen.width - NUMBERS.linkWidth)/2,
			                (Screen.height - NUMBERS.linkHeight)/2,
			                NUMBERS.linkWidth,
			                NUMBERS.linkHeight);
		}
		set {}
	}
}
