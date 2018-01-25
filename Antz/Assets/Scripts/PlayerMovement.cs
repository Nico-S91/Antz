using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D playerRigidBody;
    public float speed = 2f;

	// Inicializacion del objeto
	void Start () {
		
	}
	
	// Esto se llama una vez por frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow)) {
            playerRigidBody.velocity = new Vector2(0, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            playerRigidBody.velocity = new Vector2(0, -speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            playerRigidBody.velocity = new Vector2(-speed, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            playerRigidBody.velocity = new Vector2(speed, 0);
        }

	}
}
