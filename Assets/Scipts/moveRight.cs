using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private float speed = 20f;
    private LogicScript logicScript;
    private float leftBound = -10f;

    private void Start()
    {
        logicScript = GameObject.Find("Logic Manager").GetComponent<LogicScript>();
    }


    void Update()
    {
        
        { 
            transform.Translate(Vector3.right * Time.deltaTime * (speed));
        }
    }

        //if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        //{
        //    Destroy(gameObject);
        //}

    
}
