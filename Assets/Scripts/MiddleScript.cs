using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //set the tag of the Logicscript and locate it using the tag
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);

        if (collision.gameObject.layer == 3 && logic.gameOn)
        {
            logic.AddScore(1);
        //    logic.pointSFX.Play();
        }
    }
}
