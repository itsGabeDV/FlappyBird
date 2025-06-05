using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); //references the players rigid body
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            body.velocity = Vector2.zero;
            body.AddForce(Vector2.up * speed, ForceMode2D.Impulse);// force to accumulate more naturally instead of setting velocity
        }
    }
}
