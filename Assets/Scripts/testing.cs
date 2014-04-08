using UnityEngine;
using System.Collections;

public class testing : MonoBehaviour {
	public GUISkin skin;
	EmotionWheal em;
	public string s = "";
	public Link l;
	// Use this for initialization
	void Start () {
		this.em = new EmotionWheal();
		this.l = new Link("MultiMedia/CalibrationText.txt");
	}
	
	// Update is called once per frame
	void Update () {
		this.s = this.l.displayedText;
	}

	void OnGUI(){
		GUI.skin = skin;
		GUI.skin.box.fontSize = (int) GLOBALS.fontSize;
		GUI.Box(new Rect(Screen.width/2 - 400,Screen.height/2 - 300,800,600),s);
		GLOBALS.textScrollSpeed = GUI.HorizontalSlider(new Rect(40,0,Screen.width-40,40),GLOBALS.textScrollSpeed,0,0.75f);

		GLOBALS.fontSize = GUI.VerticalSlider(new Rect(0,40,40,Screen.height-40),GLOBALS.fontSize,8,40);
	}
}