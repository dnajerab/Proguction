using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public int jumps;
    Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        jumps = 0;
        vel = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        vel = new Vector3(0, rb.velocity.y, 0);
        if (Input.GetKey(KeyCode.A)) {  // move left
            vel += new Vector3(-5, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)) {  // move right
            vel += new Vector3(5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) {  // dash
            vel = new Vector3(7, rb.velocity.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) ) {  // jump
            Debug.Log(vel + " " + jumps);
            if (jumps < 2) {

                jumps++;
                vel += new Vector3(0, 10, 0);
            }
        }
        rb.velocity = vel;
    }

    public void test()
    {
        jumps = 0;
    }
    
}
