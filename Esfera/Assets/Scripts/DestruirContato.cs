using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirContato : MonoBehaviour {
	public GameObject explosao;
	public GameObject explosaonave;
	public int vida = 1;
	void OnTriggerEnter(Collider outroCollider){
		if (outroCollider.CompareTag ("Limite"))
			return;
		vida = vida-1;
		if (vida == 0) {
			Destroy (outroCollider.gameObject);
			Destroy (this.gameObject);
			Instantiate (explosao, transform.position, transform.rotation);
			if (outroCollider.tag == "DestruicaoNave") {
				Instantiate (explosaonave, transform.position, transform.rotation);
			}
		}
	}
}
