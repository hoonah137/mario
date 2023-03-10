using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float speed = 6.5f;

    Rigidbody2D rBody;

    float horizontal;

    SFXManager sfxManager;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

         rBody.velocity= new Vector2(horizontal * speed, rBody.velocity.y);

        
    }

    public void Die ()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {

        if(collision.gameObject.tag == "noGoomba")
        {
            if (horizontal == 1)
            {
                horizontal = -1;
            }
            else 
            {
                horizontal = 1;
            }

            
        }
        
        if(collision.gameObject.tag == "player")   
        {
            Debug.Log("ESO TE PASA POR INTENTAR MATAR A MIS GOOMBITAS!!!");
            Destroy(collision.gameObject);
            
        }
        
    }
}
