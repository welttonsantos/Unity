using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {
	Rigidbody componente;
	public int velocidade = 0;
	public int tamanhoPulo = 0;

	Vector3 movimento;
	Vector3 pulo;
	bool podePular = false;

	// Use this for initialization
	void Start () {
		Debug.Log("oi");
        componente = GetComponent<Rigidbody> ();
		
	}
	void onColliderEnter (Collision outro){
		podePular = true;
	}
	// Update is called once per frame
	void Update () {
		Mover();
		Pular ();

}
	void Mover(){
		float MovHor = Input.GetAxis ("Horizontal");
		float MovVer = Input.GetAxis ("Vertical");
		movimento = new Vector3 (MovHor, 0, MovVer);
		componente.AddForce (movimento * velocidade);
	}
	void Pular(){
		if (Input.GetButtonDown ("Jump") && podePular) {
			podePular = false;
			pulo = new Vector3 (0, tamanhoPulo, 0);
			componente.AddForce (pulo, ForceMode.Impulse);
		}
	}
}