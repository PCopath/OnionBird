using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource flipSound;
    public AudioSource dieSound;
    public GameObject mermiPrefab;
   
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * flapStength;
            flipSound.Play();
        }
        if (transform.position.y > 16 || transform.position.y < -16)
        {
            birdIsAlive = false;
            dieSound.Play();
            logic.gameOver();
        }
        if (Input.GetKeyDown(KeyCode.E) == true && birdIsAlive)
        {
            Instantiate(mermiPrefab, transform.position, mermiPrefab.transform.rotation);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("mermi"))
        {
            logic.gameOver();
            birdIsAlive = false;
            dieSound.Play();
        }
    
    }
}
