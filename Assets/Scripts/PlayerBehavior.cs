using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	//Nota: o Player está com Fixed rotation Z (Impede que o Rigidbody gire o Player ao encostar em superfícies irregulares), da pra desativar isso no Rigidbody2D

	public enum State {Gas,Liquid,Solid}
	public State myState;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
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
		
	void FixedUpdate () {
		//Inputs de teste
		if (Input.GetKeyDown (KeyCode.Alpha1))
			GoToGas ();
		if (Input.GetKeyDown (KeyCode.Alpha2))
			GoToLiquid ();
		if (Input.GetKeyDown (KeyCode.Alpha3))
			GoToSolid ();
	}

	//Use os "GoTo..." para alterar imediatamente para o estado escolhido
	//Use os "Heat" e "Cool" para alterar uma etapa na direção da temperatura escolhida (Ex: Heat altera o Solido para Liquido, e o Liquido para Gas)

	public void GoToGas (){
		myState = State.Gas;
		rb.gravityScale = -0.5f;
	}

	public void GoToLiquid (){
		myState = State.Liquid;
		rb.gravityScale = 1;
	}

	public void GoToSolid (){
		myState = State.Solid;
		rb.gravityScale = 3;
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
