using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

    private float speedX;
    private Rigidbody2D rb;
    public float speedMultiplier = 50f;
    public float acceleration = 1000f;
    private bool isGrounded = false;
    public float jumpForce = 3000f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>() as Rigidbody2D;
		
	}

    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded == true)
        {
            isGrounded = false;
            rb.AddForce(new Vector2(0f, jumpForce));
            gameObject.layer = 10;
        }
        
    }
    // Update is called once per frame
    void FixedUpdate () {


        if (rb.velocity.y <= -1f) { gameObject.layer = 9; }
        RaycastHit2D hit =Physics2D.Raycast(new Vector2(transform.position.x,transform.position.y -0.5f), Vector2.up * -1, 0.3f);
        if (hit.collider != null)
        {
           
            isGrounded = true;
        }
        else { isGrounded = false; }
        Debug.Log(isGrounded);

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y-0.9f);
        float inputX = Input.GetAxis("Horizontal");
        
        speedX = inputX * speedMultiplier;
        
        float speedInFrame = speedX - rb.velocity.x;
        
        float accelerationInFrame = acceleration * Time.deltaTime;
        
        speedInFrame = Mathf.Clamp(speedInFrame, -accelerationInFrame, accelerationInFrame);
        //if (rb.velocity.x < speedMultiplier)
        //{
            rb.AddForce(new Vector2(speedInFrame, 0f));
        //}
		
	}

    
}
