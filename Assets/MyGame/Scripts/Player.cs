﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 5.0f;

    private void Move () {
        var deltaX = Input.GetAxis (AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp (transform.position.x + deltaX, -5.3f, 5.3f);

        transform.position = new Vector2 (newPosX, transform.position.y);
    }

    // Update is called once per frame
    void Update () {
        Move ();
    }
}