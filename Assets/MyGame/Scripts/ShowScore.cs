using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour {
	public TextMeshProUGUI scorepoints;
	public MyScore scoreCount;
	// Use this for initialization
	void Start () {
		scorepoints.text = scoreCount.score.ToString ();
	}

}