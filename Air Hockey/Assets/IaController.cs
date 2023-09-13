using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject disco;

    public float boundY = -8.4f;
    public float boundX = -18f;

    void SegueBola(){
        Vector2 pos;
        pos.y = rb2d.position.y;
        pos.x = rb2d.position.x;
        if(disco.transform.position.y > pos.y && disco.transform.position.x < 0){
            pos.y += 0.05f;
        }
        if(disco.transform.position.y < pos.y && disco.transform.position.x < 0){
            pos.y -= 0.05f;
        }

        if(disco.transform.position.x > pos.x && disco.transform.position.x < 0){
            pos.x += 0.05f;
        }
        if(disco.transform.position.x < pos.x && disco.transform.position.x < 0){
            pos.x -= 0.05f;
        }
        transform.position = pos; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        disco = GameObject.FindWithTag("Disco");

    }

    // Update is called once per frame
    void Update()
    {
        SegueBola();

        var pos = transform.position;
        if (pos.y < boundY) {
        	pos.y = boundY;
    	}
   	    else if (pos.y > -boundY) {
        	pos.y = -boundY;
    	}

        if (pos.x < boundX) {
        	pos.x = boundX;
    	}
   	    else if (pos.x > -11f) {
        	pos.x = -11f;
    	}
    	transform.position = pos;
    }
}
