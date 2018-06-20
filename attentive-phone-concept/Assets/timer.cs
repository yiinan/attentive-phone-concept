using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public float totalTime;
	public bool testTime = true;
	static bool isLook = false;
	public GameObject alertWindow;
	public Text text;

	// Use this for initialization
	void Start () {
		//totalTime = 3.0f;
		alertWindow.SetActive (false);
		GameObject.Find ("Canvas/LookState/Text").GetComponent<Text> ().text = "notLook";
	}		
	
	// Update is called once per frame
	void Update () {
		if(isLook){
			totalTime -= Time.deltaTime;
		}
		//totalTime -= Time.deltaTime;
		//Debug.Log (totalTime);
		if (totalTime <= 0 && testTime) {
			alertWindow.SetActive (true);
			Debug.Log("timer is up.");
			testTime = false;
		}
	}

	public void lookORnotlook(){
		isLook = !isLook;
		if (isLook) {
			GameObject.Find ("Canvas/LookState/Text").GetComponent<Text> ().text = "Look";
		} else if (!isLook) {
			GameObject.Find ("Canvas/LookState/Text").GetComponent<Text> ().text = "notLook";
		}
	}
		

	public void quitApp(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
		
}
