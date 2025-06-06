using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    LogicScript logic;

    public float upForce = 50f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); //references the players rigid body
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //set the tag of the Logicscript and locate it using the tag
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = Vector2.zero;
            body.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);// force to accumulate more naturally instead of setting velocity
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            logic.GameOver(); //end the game if we collide with pipes
        }
    }
}
