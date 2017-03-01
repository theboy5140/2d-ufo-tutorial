using System.Collections;
using UnityEngine;

class BaseEnemyController : MonoBehaviour 
{

    protected float rotateSpeed;
    protected float speed;
    protected float direction;

    protected void Start()
    {
        direction = Mathf.Sign (Random.Range (-1f, 1f));
    }

    protected void Rotate()
    {
        rotateSpeed = Random.Range (0.1f, 0.5f);
        Vector3 rotator = new Vector3 (0.0f, 0.0f, 360f) * Time.deltaTime * rotateSpeed * direction;
        transform.Rotate (rotator);    
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}

