using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength = 10;
    public logicScript logic;
    public bool alive = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && alive)
        {
            birdRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive = false;
    }
}
