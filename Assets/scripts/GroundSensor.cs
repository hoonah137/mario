using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;
   private PlayerControler controller;

    private void Awake() {
      controller = GetComponentInParent<PlayerControler>();
   }

    private void OnTriggerEnter2D(Collider2D other) 
   {
      if (other.gameObject.layer == 3)
      {
         isGrounded = true;
         controller.anim.SetBool("IsJumping",false);
         }

      if(other.gameObject.tag == "Muerte")
      {
         Debug.Log("LA PALMASTE MUAJAJAJAJA");
      }

      else if (other.gameObject.layer == 6)
      {
         Debug.Log("NOOOOOOO!!! poor goomba... YOU KILLED IT!!! HOW COULD YOU !?");

         Destroy(other.gameObject);
      }
   }

   private void OnTriggerStay2D(Collider2D other) 
   {
      if (other.gameObject.layer == 3)
      {
         isGrounded = true;
         controller.anim.SetBool("IsJumping",false);
      }
   }

    private void OnTriggerExit2D(Collider2D other) 
   {
      if (other.gameObject.layer == 3)
      {
      isGrounded = false;
      controller.anim.SetBool("IsJumping",true);
      }
   }
}
 