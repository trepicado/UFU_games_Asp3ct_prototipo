using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	public enum State {Gas,Liquid,Solid}
	public State myState;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		if (myState == State.Gas) {
			GoToGas ();
		}
		if (myState == State.Liquid) {
			GoToLiquid ();
		}
		if (myState == State.Solid) {
			GoToSolid ();
		}
	}

	void Update () {
	}

	public void GoToGas (){
		myState = State.Gas;
		rb.gravityScale = -0.5f;
		rb.mass = 0.5f;
	}

	public void GoToLiquid (){
		myState = State.Liquid;
		rb.gravityScale = 1;
		rb.mass = 0.5f;
	}

	public void GoToSolid (){
		myState == State.Solid;
		rb.gravityScale = 1;
		rb.mass = 1;
	}

	public void Heat(){
		if (myState == State.Solid) {
			GoToLiquid ();
		}
		if (myState == State.Liquid) {
			GoToGas ();
		}
	} 

	public void Cool(){
		if (myState == State.Gas) {
			GoToLiquid ();
		}
		if (myState == State.Liquid) {
			GoToSolid ();
		}
	}
}
