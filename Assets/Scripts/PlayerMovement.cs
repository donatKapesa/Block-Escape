using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 250;
    public float sideForce = 200;
     

    /*
     * Two problems:
     * Input.GetKey is not very good e.g. if you using a Tablet
     * Player movement should be inside Update and not Fixed Update
     */

	void FixedUpdate () {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // because framerate differs on diff computers

        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
