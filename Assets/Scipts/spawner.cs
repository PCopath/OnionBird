using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    
    public  GameObject[] myObjects;

    public float spawnRate = 5.0f;

    
    public float timer = 0;
    public float timer1 = 0;
    public float heightOffset = 10;
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(myObjects[Random.Range(0,2)], new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z), Quaternion.identity); 
    }
  
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
      
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (timer1 > 5.0f)
        //{
            
        //    spawnPipe1();
        //    timer1 = 0;
        //}

        //if (timer > 8.0f)
        //{
        //    timer = 0;
        //    spawnPipe();
        //}

        //timer = timer + Time.deltaTime;
        //timer1 = timer1 + Time.deltaTime;

        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    

}
