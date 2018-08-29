using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour {

	private float vel;
	public float vel_reduce;
	public float min_vel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.layer == 8) {
			vel = Mathf.Sqrt ((Mathf.Pow (col.attachedRigidbody.velocity.x,2) + Mathf.Pow (col.attachedRigidbody.velocity.y,2)));
			if (vel >= min_vel) {
				col.attachedRigidbody.AddForce (new Vector2((-col.attachedRigidbody.velocity.x) *vel_reduce, (-col.attachedRigidbody.velocity.y)*vel_reduce),ForceMode2D.Impulse);
				Destroy (this.gameObject);
			}
		}
	}
}
