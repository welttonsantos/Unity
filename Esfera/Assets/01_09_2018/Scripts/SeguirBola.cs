using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirBola : MonoBehaviour {
	public GameObject objeto;
	private Vector3 distancia;

	// Use this for initialization
	void Start () {
		distancia = transform.position - objeto.transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = objeto.transform.position + distancia;
		
	}
}
