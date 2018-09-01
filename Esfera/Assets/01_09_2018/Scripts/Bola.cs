using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	private Rigidbody componenteRb;
	public int velocidade = 5;

	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
	}
	void OnTriggerEnter(Collider outro){
		Destroy (outro.gameObject);
	}
	//void OnTriggerEnter(){
	//	Debug.Log ("Atravessou");
	//}

	void Update () {
		float x = Input.GetAxis ("Horizontal");
		//Debug.Log (x  + " | " + z );
		Vector3 movimento = new Vector3 (x, 0, 1);
		componenteRb.AddForce (movimento * velocidade);
	}
}
