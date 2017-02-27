﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extra.Tess;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
        rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.CompareTag ("PickUp")) {
            other.gameObject.SetActive (false);
        }
    }
}
