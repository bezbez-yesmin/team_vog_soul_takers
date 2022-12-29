using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashmouvment : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
        }
        if(Input.GetKey("a"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
        }
        if(Input.GetKey("w"))
        {
            rb.velocity = Vector2.up * 10;
        }
        if(Input.GetKey("s"))
        {
            rb.velocity = Vector2.down * 10;
        }
        if(Input.GetKeyUp("d") || Input.GetKeyUp("a") || Input.GetKeyUp("w") || Input.GetKeyUp("s")) 
        {
            rb.velocity = Vector2.zero;
        }
    }
}
