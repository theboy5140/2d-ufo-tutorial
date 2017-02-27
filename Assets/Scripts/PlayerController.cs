using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{

    public float speed = 2;
    public float rotateSpeed = 1;

    public int LEVEL_ONE_SCORE = 0;
    public int LEVEL_TWO_SCORE = 10;
    public int LEVEL_THREE_SCORE = 50;

    private float direction;
    private GameController gameController;
    private Rigidbody2D rigidBody;

	void Start () 
    {
        rigidBody = GetComponent<Rigidbody2D> ();
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        direction = Mathf.Sign (Random.Range (-1, 1));
    }
	
	void Update () 
    {
        ControlInput ();
    }

    void FixedUpdate()
    {
        RotatePlayer ();
    }

    void ControlInput()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rigidBody.AddForce (movement * speed);
    }

    void RotatePlayer()
    {
        Vector3 rotator = new Vector3 (0.0f, 0.0f, 360) * Time.deltaTime * rotateSpeed * direction;
        transform.Rotate (rotator);
    }
}
