using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuController : MonoBehaviour {

    public float rotateSpeed = 1;
    public GameObject bearImage;

    private float direction;

    // Use this for initialization
	void Start () {
        direction = Mathf.Sign (Random.Range(-1f, 1f));
    }
	
	// Update is called once per frame
	void Update () {
        bearImage.transform.Rotate (new Vector3(0.0f, 0.0f, 360f) * Time.deltaTime * rotateSpeed);
        Debug.Log ("rolling in bear");
	}
}
