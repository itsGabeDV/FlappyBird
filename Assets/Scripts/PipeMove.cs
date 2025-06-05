using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed;
    public float leftOutbound;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

         if (transform.position.x < leftOutbound)// destroy pipes is they go out of bounds     
        {
            Destroy(gameObject);       
        }
    }
}
