using System.Collections;
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
        Vector2 origin = transform.position;
        this.transform.position = origin + new Vector2(moveHorizontal, moveVertical);
        Debug.Log ("horizontal is :" + moveHorizontal);
        Debug.Log ("vertical is :" + moveVertical);
    }
}
