using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCherry : MonoBehaviour {
    public Cherry cherryPrefab;
    public GameObject cherryParent;

    private void Update () { }

    IEnumerator Start () {
        while (true) {
            yield return new WaitForSeconds (2);
            SpawnCh ();
        }

    }

    private void SpawnCh () {
        Cherry cherryClone = (Cherry) Instantiate (cherryPrefab, transform.position, transform.rotation);
        float flySize = 0.3f;
        cherryClone.transform.SetParent (cherryParent.transform); //gibt Parent
        cherryClone.transform.localScale = new Vector3 (flySize, flySize, 0);
        cherryClone.transform.localPosition = new Vector3 (UnityEngine.Random.Range (-5f, +5f), cherryParent.transform.position.y, 5f); //setze lokale Pos
        cherryClone.GetComponent<Rigidbody2D> ().velocity = new Vector2 (UnityEngine.Random.Range (-2, 2), UnityEngine.Random.Range (-10, -1));
    }

}