using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {
	/*
	public GameObject asteroide1;
	public GameObject asteroide2;
	*/
	public GameObject boss;
	private float frequencia = 0.5f;
	public GameObject[] asteroides;

	void Start () {
		StartCoroutine ("Aparecer");
	}
	
	IEnumerator Aparecer(){
		for(int j=0;j<2;j++){
			for (int i=0;i<20;i++){
				int indice = Random.Range (0, 3);
				Vector3 posicao = transform.position;
				Limite limite = new Limite ();
				posicao.x = Random.Range (limite.xMin, limite.xMax);
				Instantiate (asteroides[indice], posicao, transform.rotation);
				yield return new WaitForSeconds (frequencia);
			}
			yield return new WaitForSeconds (3);
		}	
		Vector3 posicao2 = transform.position;
		Limite limite2 = new Limite ();
		posicao2.x = Random.Range (limite2.xMin, limite2.xMax);
		Instantiate (boss, posicao2, transform.rotation);
		yield return new WaitForSeconds (frequencia);
	}
}

