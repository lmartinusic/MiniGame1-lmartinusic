using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour {
    // dadurch kann ich auf die Komponente zugreifen in Unity dann noch zuweisen
    public TextMeshProUGUI pointsScore;
    public MyScore score;

    private void OnTriggerEnter2D (Collider2D collision) {
        Debug.Log ("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "Mary") {
            score.score += 5;
            Debug.Log ("score " + score);
            pointsScore.text = score.score.ToString ();

        } else if (collision.gameObject.name == "ColliderBottom") {
            score.score -= 10;
            Debug.Log ("score " + score);
            pointsScore.text = score.score.ToString ();
        }
    }
    private void OnCollisionEnter2D (Collision2D collision) {
        Debug.Log ("CollisionEvent");
    }
}