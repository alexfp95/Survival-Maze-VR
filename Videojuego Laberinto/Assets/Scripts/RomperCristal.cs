using UnityEngine;
using System.Collections;

public class RomperCristal : MonoBehaviour {

	public AudioClip clip;

	private AudioSource source;
	private GameObject scriptsContenedor;
	private Inventario inventario;

	void Awake () {
		scriptsContenedor = GameObject.FindGameObjectWithTag ("Scripts");
		inventario = scriptsContenedor.GetComponent<Inventario> ();
		source = GetComponent<AudioSource> ();
	}

	void OnCollisionStay (Collision other) {
		if (other.gameObject.tag == "Player") {
			if (inventario.itemActual ("Piedra")) {
				if (Input.GetMouseButtonDown (0)) {
					source.PlayOneShot (clip, 0.5f);
					this.gameObject.GetComponent<MeshRenderer> ().enabled = false;
					Destroy (this.gameObject.GetComponent<Rigidbody> ());
					Destroy (this.gameObject.GetComponent<BoxCollider> ());
				}
			}
		}
	}
}
