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
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, -speed);
        }
	}
}
