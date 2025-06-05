using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate;

    public float timer;
    public float heightOffset;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //tick up timer

        if (timer > spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }

    }

    void SpawnPipe()
    {
        float lowPoint = transform.position.y - heightOffset;
        float highPoint = transform.position.y + heightOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation); //pipes will spawn in empty game object pipespawner transform location
    }//Vector =3 when specifying our own numbers for a Vector,arguments are(x cords, y cords, z cords)
    //Random.Range(between two bounds)
}
