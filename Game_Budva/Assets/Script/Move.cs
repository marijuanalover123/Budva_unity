using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{
    public int speed = 5; 
    public float jump = 2; 
    private int score = 0;
    public TMP_Text scoreText;
    public bool grounded = false;
    private AudioSource audio;
    public AudioClip audiojump, audiotake;
    public SpriteRenderer SpriteRenderer;
   
    private void Awake()
    {
     audio = GetComponent<AudioSource>();
     
    }

    private void Update(){
        SpriteRenderer SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();   
       if(Input.GetKey(KeyCode.D)) {
           transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);
           
            SpriteRenderer.flipX = false;
         }
       if(Input.GetKey(KeyCode.A)) {
           transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * speed);    
           SpriteRenderer.flipX = true;
       }   
       if (Input.GetKeyDown(KeyCode.Space) && grounded){
            audio.clip =  audiojump;
            audio.Play(); 
            GetComponent<Rigidbody2D>().AddForce(transform.up * jump, ForceMode2D.Impulse); 
       }
    }


    private void OnCollisionEnter2D(Collision2D other){
         grounded = true; 
          audio.clip =  audiojump;
            audio.Play(); 
    }
    private void OnCollisionExit2D(Collision2D other){
         grounded = false;
    }

      private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "Colect box"){
     Destroy (other.gameObject);
     audio.clip =  audiotake;
        audio.Play();
     score++;
     if (score != 4)
         scoreText.text = "Box: " + score; 
     else
         scoreText.text = "you win!";
    }
    
}

}






