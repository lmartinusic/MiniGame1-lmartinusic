using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collectible : MonoBehaviour {
    // dadurch kann ich auf die Komponente zugreifen in Unity dann noch zuweisen
    public TextMeshProUGUI pointsScore;
    public MyScore score;
    public Text countText;

    private int count;

    private void OnTriggerEnter2D (Collider2D collision) {
        Debug.Log ("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "Mary") {
            score.score += 5;
            Debug.Log ("score " + score);
        } else if (collision.gameObject.name == "ColliderBottom") {
            score.score -= 10;
            Debug.Log ("score " + score);
        }
    }
    private void OnCollisionEnter2D (Collision2D collision) {
        Debug.Log ("CollisionEvent");
    }

    private void Update () {
        pointsScore.text = score.score.ToString ();
        if (score.score == 120) {
            SceneManager.LoadScene ("GoodEndScene");
        }
    }
}