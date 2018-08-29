using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanBehavior : MonoBehaviour {

	public enum Side {Esquerda,Direita};
	public Side mySide;
	public float vel;
	private Vector2 vectDir;
	private Vector2 vectEsq;

	// Use this for initialization
	void Start () {
		vectDir = new Vector2 (vel, 0);
		vectEsq = new Vector2 (-vel, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.layer == 11) {
			if (mySide == Side.Direita) {
				col.attachedRigidbody.AddForce (vectDir);
			} else {
				col.attachedRigidbody.AddForce (vectEsq);
			}
		}
	}
}
