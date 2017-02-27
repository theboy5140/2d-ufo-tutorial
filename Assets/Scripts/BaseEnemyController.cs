using System.Collections;
using UnityEngine;

class BaseEnemyController : MonoBehaviour 
{

    public float rotateSpeed = 1;
    public float speed = 1;
    public float direction = 1;

    protected void Start()
    {
        direction = Mathf.Sign (Random.Range (-1, 1));
    }

    protected void Rotate()
    {
        Vector3 rotator = new Vector3 (0.0f, 0.0f, 360) * Time.deltaTime * rotateSpeed * direction;
        transform.Rotate (rotator);    
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}

