//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 5; 
    public float jump = 2; 
    public bool grounded = false;
      private void Update(){
       if(Input.GetKey(KeyCode.D)) 
           transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);
       if(Input.GetKey(KeyCode.A)) 
           transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * speed);    
              
       if (Input.GetKey(KeyCode.Space) && grounded)
            GetComponent<Rigidbody2D>().AddForce(transform.up * jump, ForceMode2D.Impulse);   
    }

    private void OnCollisionEnter2D(Collision2D other){
         grounded = true; 
    }
   // private void OnCollisionExit2D(Collision2D other){
      //   grounded = false;

 
   }

//}


