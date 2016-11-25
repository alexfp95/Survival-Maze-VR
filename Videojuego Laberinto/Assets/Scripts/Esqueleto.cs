using UnityEngine;
using System.Collections;

public delegate void metodoDelagado ();

public class Esqueleto : MonoBehaviour {

	public event metodoDelagado Evento;

	void Start () {}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Evento ();
			GameObject.FindGameObjectWithTag ("Altavoz").GetComponent<Maldicion> ().escucharMaldicion ();
			Destroy (this.gameObject);
		}
	}
		
}
