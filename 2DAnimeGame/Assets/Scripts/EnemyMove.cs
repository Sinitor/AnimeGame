using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public float distance;
    
    private void Start()
    {
        speed = 2;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -distance)
        {
            speed = -speed;
        }
        if (transform.position.x > distance)
        {
            speed = 2;
        }
    }
}
