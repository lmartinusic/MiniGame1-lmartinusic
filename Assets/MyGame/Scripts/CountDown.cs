using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	public int timeLeft = 60; //Seconds Overall
	public TextMeshProUGUI countdown; //UI Text Object

	void Start () {
		StartCoroutine ("LoseTime");
		Time.timeScale = 1; //Just making sure that the timeScale is right
	}

	void Update () {
		countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
		if (timeLeft == 0) {
			SceneManager.LoadScene ("EndScene");
		}
	}

	//Simple Coroutine
	IEnumerator LoseTime () {
		while (true) {
			yield return new WaitForSeconds (1);
			timeLeft--;
		}

	}
}