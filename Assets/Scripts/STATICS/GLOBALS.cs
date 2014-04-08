using UnityEngine;
using System.Collections;

public static class GLOBALS {
	private static float _textScrollSpeed = 0.25f;
	public static float textScrollSpeed {
		get {
			return GLOBALS._textScrollSpeed;
		} set {
			GLOBALS._textScrollSpeed = value;
		}
	}
	private static float _fontSize = 20.0f;
	public static float fontSize {
		get {
			return GLOBALS._fontSize;
		} set {
			GLOBALS._fontSize = value;
		}
	}


}
