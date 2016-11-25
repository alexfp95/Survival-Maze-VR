using UnityEngine;
using System.Collections;

public class ApagarAntorcha : MonoBehaviour {

	void Start () {
		GameObject.FindWithTag ("Esqueleto").GetComponent<Esqueleto> ().Evento += MetodoEjecutar;
	}
	

	void MetodoEjecutar () {
		Destroy (this.gameObject);
	}
}
