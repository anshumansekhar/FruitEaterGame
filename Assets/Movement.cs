using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    private float speed = 20f;
    private Rigidbody2D player;

	// Use this for initialization
	void Awake () {
        player=GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 vel = player.velocity;
        vel.x=Input.acceleration.x*speed;
        //vel.x = Input.GetAxis("Horizontal") * speed;
        player.velocity = vel;
	
	}
}
