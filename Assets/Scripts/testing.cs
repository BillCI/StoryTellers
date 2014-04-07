using UnityEngine;
using System.Collections;

public class testing : MonoBehaviour {
	EmotionWheal em;
	// Use this for initialization
	void Start () {
		this.em = new EmotionWheal();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Box(new Rect(0,0,Screen.width,Screen.height),em.fear.name);
		if(GUI.Button(new Rect(0,0,100,100),"ok now")) {
			System.Xml.Serialization.XmlSerializer writer = 
				new System.Xml.Serialization.XmlSerializer(typeof(EmotionWheal));
			
			System.IO.StreamWriter file = new System.IO.StreamWriter(
				@"testSaveFile.xml");
			writer.Serialize(file, em);
			file.Close();
		}
	}
}
public class Book
{
	public string title; 
}
