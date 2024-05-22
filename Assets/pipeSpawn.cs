using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 6;
    // Start is called before the first frame update
    void Start()
    {
		spawn();
	}

	// Update is called once per frame
	void Update()
    {
        if (timer < spawnRate)
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
        float lowestPosition = transform.position.y - heightOffset;
        float highestPosition = transform.position.y + heightOffset;
		Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPosition,highestPosition),0),transform.rotation);
	}
}
