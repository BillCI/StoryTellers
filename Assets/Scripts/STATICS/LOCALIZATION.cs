using UnityEngine;
using System.Collections;

public static class LOCALIZATION {
	public enum language {english}

	private static LOCALIZATION.language _currentLanguage = LOCALIZATION.language;
	public static LOCALIZATION.language currentLanguage {
		get {
			return LOCALIZATION._currentLanguage;
		}
		set {
			//TODO: implemnt some sort of language seltion;
		}
	}

}
