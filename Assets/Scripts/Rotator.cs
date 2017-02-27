using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
    public float speed = 1;

    private Vector3 rotator;

	void Start () {
		
        rotator = RandomRotateAngle ();
	}
	
	// Update is called once per frame
	void Update () {
		
        transform.Rotate (rotator * Time.deltaTime * speed);
	}

    private Vector3 RandomRotateAngle(){
    
        return new Vector3 (0.0f, 0.0f, 1f) * Random.Range (0, 360) * Mathf.Sign(Random.Range(-1, 1));
    }
}
