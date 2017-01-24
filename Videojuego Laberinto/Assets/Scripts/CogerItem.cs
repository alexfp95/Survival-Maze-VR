using UnityEngine;
using System.Collections;

public class CogerItem : MonoBehaviour, IGvrGazeResponder {

	private GameObject scriptsContenedor;
	private PlayerBD jugadorBD;

	void Awake () {
		scriptsContenedor = GameObject.FindGameObjectWithTag ("Scripts");
		jugadorBD = scriptsContenedor.GetComponent<PlayerBD> ();
	}

	public void OnGazeEnter () {
		if (Input.GetAxis("Fire2") != 0) {
			cogerItem ();
		}
		Debug.Log ("Colision");
	}

	public void OnGazeTrigger () {
		
	}

	public void OnGazeExit () {
		
	}

	public void cogerItem () {
		for (int i = 0; i < jugadorBD.slots.Length; i++) {
			if (jugadorBD.slots [i] == "") {
				jugadorBD.slots [i] = this.tag;
				Debug.Log ("Cogio: " + jugadorBD.slots [i]);
				Destroy (this.gameObject);
				return;
			}
		}
	}
}
