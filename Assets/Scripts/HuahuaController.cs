using System;
using UnityEngine;

class HuahuaController : BaseEnemyController
{

    public int score = 1;

    private String playerTag = "Player";

    private GameController gameController;

    void Start()
    {
        base.Start ();
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        Rotate ();
    }

    void FixedUpdate()
    {
        
    }

    void LateUpdate()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag (playerTag))
        {
            gameController.AddScore (score);
            gameController.ShowScore ();
            gameObject.SetActive (false);
        }
    }
}
