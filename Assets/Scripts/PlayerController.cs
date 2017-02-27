using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Extra.Tess;

public class PlayerController : MonoBehaviour {

    public float speed = 10;
    public float rotateSpeed = 2;
    public Text countText;
    public Text winText;

    private Rigidbody2D rb;
    private int count = 0;
    private float direction;

	// Use this for initialization
	void Start () {
		
        winText.text = "";
        rb = GetComponent<Rigidbody2D> ();
        direction = Mathf.Sign (Random.Range (-1, 1));
    }
	
	// Update is called once per frame
	void Update () {
	
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb.AddForce (movement * speed);
        addRotation ();

    }

    void FixedUpdate(){
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.CompareTag ("PickUp")) {
            other.gameObject.SetActive (false);
            count += 1;
            SetCountText ();
        }
    }

    void SetCountText(){
        countText.text = "SCORE :　" + count.ToString();
        if (count >= 12) {
            winText.text = "YOU WIN!";
        }
    }

    void addRotation(){

        Vector3 rotator = new Vector3 (0.0f, 0.0f, 360) * Time.deltaTime * rotateSpeed * direction;
        transform.Rotate (rotator);
    }
}
