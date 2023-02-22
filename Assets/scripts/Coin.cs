using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Animator cling;
    
    // Start is called before the first frame update
 private void Awake() {


        cling = GetComponent<Animator> (); 
    }

   
}
