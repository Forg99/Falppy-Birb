using System.Threading;
using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 6;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer = timer + Time.deltaTime;
            

        }
        else
        {
            spwanPipe();
            timer = 0;
        }

    }
    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate (Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),2), transform.rotation);
    }
}
