using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

	public GameObject playerPrefab;
	public Text scoreText;

	private float timeElapsed = 0f;
	private bool gameStarted;
	private TimeManager timeManager;

	void Awake(){
		timeManager = GetComponent<TimeManager> ();
	}

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) {
			timeManager.ManipulateTime (1, 1f);
		} 
		else if (playerPrefab.activeInHierarchy == true) {
			timeElapsed += Time.deltaTime;
			scoreText.text = "TIME: " + FormatTime (timeElapsed);
		} 
	}

	string FormatTime(float value){
		TimeSpan t = TimeSpan.FromSeconds (value);

		return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
	}

}
