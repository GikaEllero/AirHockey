using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void GoBall(){
    	float rand = Random.Range(0, 2);
    	if(rand < 1){
        	rb2d.AddForce(new Vector2(30, -20));
    	} else {
        	rb2d.AddForce(new Vector2(-30, -20));
    	}
    }

    void OnCollisionEnter2D (Collision2D coll) {
    	if(coll.collider.CompareTag("Player")){
        	Vector2 vel;
        	vel.x = rb2d.velocity.x;
            Debug.Log("velx - " + vel.x);
        	vel.y = rb2d.velocity.y + coll.collider.attachedRigidbody.velocity.y;
            Debug.Log("vely - " + vel.y);
        	rb2d.velocity = vel;
    	}
    }


    void ResetBall(){
    	rb2d.velocity = Vector2.zero;
    	transform.position = Vector2.zero;
    }

    void RestartGame(){
    	ResetBall();
    	Invoke("GoBall", 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    	Invoke("GoBall", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
