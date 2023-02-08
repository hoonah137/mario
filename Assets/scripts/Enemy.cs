using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.5 f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         rBody.velocity = new Vector2(horizontal * speed, rBody.velocity.y);

        
    }

    public void Die ()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "player")   
        {
            Debug.Log("ESO TE PASA POR INTENTAR MATAR A MIS GOOMBITAS!!!");
            Destroy(collision.gameObject);
        }

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
        
    }
}
