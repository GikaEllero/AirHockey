using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float boundY = 8.4f;
    public float boundX = 20.6f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        pos.x = mousePos.x;
        pos.y = mousePos.y;

    	if (pos.y > boundY) {
        	pos.y = boundY;
    	}
   	    else if (pos.y < -boundY) {
        	pos.y = -boundY;
    	}

        if (pos.x > boundX) {
        	pos.x = boundX;
    	}
   	    else if (pos.x < 11f) {
        	pos.x = 11f;
    	}
    	transform.position = pos;
    }
}
