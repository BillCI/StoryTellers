using UnityEngine;
using System.Collections;

public class textScrolSpeed : MonoBehaviour {
	private float maxScrollSpeed = 0.6f;
	private float minFontSize = 8;
	private float maxFontSize = 40;

	public GUISkin skin;
	private string calibration_text_file = "MultiMedia/CalibrationText.txt";
	private Link l;

	// Use this for initialization
	void Start () {
		l = new Link(this.calibration_text_file);
	}
	
	// Update is called once per frame
	void Update () {
		if(l.atTheEndOfLink){
			l = new Link(this.calibration_text_file);
		}
	}

	void OnGUI () {
		GUI.skin = skin;
		GUI.skin.box.fontSize = (int) GLOBALS.fontSize;

		GUI.Box(Link.rect,
		        this.l.displayedText);


		GLOBALS.textScrollSpeed = this.maxScrollSpeed - GUI.HorizontalSlider(new Rect(Link.rect.x,
		                                                                              Link.rect.y - 20,
		                                                                              Link.rect.width,
		                                                                              20),
		                                                                     (this.maxScrollSpeed - GLOBALS.textScrollSpeed),
		                                                                     0,
		                                                                     this.maxScrollSpeed);
		
		GLOBALS.fontSize = this.maxFontSize - GUI.VerticalSlider(new Rect(Link.rect.x - 20,
		                                                                  Link.rect.y,
		                                                                  20,
		                                                                  Link.rect.height),
		                                                         (this.maxFontSize - GLOBALS.fontSize),
		                                                         this.minFontSize,
		                                                         this.maxFontSize);
	}
}
