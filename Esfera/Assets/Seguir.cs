using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour {
	public GameObject jogador;
	Vector3 distancia;

	// Use this for initialization
	void Start () {
		//jogador = GameObject.FindWithtag("player");
		distancia = gameObject.transform.position - jogador.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = jogador.transform.position + distancia;
		
	}
}
