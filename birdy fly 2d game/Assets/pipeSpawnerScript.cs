using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawn();
            timer = 0;
        }
    }
    void spawn()
    {   
        float lowerPoint = transform.position.y - heightOffset;
        float upperPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowerPoint , upperPoint), 0), transform.rotation);
    }
}
