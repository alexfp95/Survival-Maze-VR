using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	public Transform inicioRayCast;
	private GameObject scriptsContenedor;
	private ObjectsBD nombreObjetos;
	private PlayerBD jugadorBD;
	private RaycastHit hit;
	public int slotActual;

	void Awake () {
		scriptsContenedor = GameObject.FindGameObjectWithTag ("Scripts");
		nombreObjetos = scriptsContenedor.GetComponent<ObjectsBD> ();
		jugadorBD = scriptsContenedor.GetComponent<PlayerBD> ();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		navegacion ();
		Debug.DrawRay (inicioRayCast.position, inicioRayCast.forward, Color.white);
		if (Physics.Raycast (inicioRayCast.position, inicioRayCast.forward, out hit)) {
			if ((Input.GetKey (KeyCode.E)) || (Input.GetAxis("Fire2") != 0)) {
				if (hit.collider.CompareTag ("Pulsador")) {
					Pulsador p = hit.collider.gameObject.GetComponent<Pulsador> ();
					if (!p.isActive ()) {
						p.push ();
						GameObject.FindGameObjectWithTag ("PuertaSalida").GetComponent<Desbloqueo> ().insertar (p.code);
					}
				} else if (hit.collider.CompareTag ("Reset")) {
					GameObject.FindGameObjectWithTag ("PuertaSalida").GetComponent<Desbloqueo> ().reset ();
				} else {
					for (int i = 0; i < nombreObjetos.items.Length; i++) {
						if (hit.collider.CompareTag (nombreObjetos.items [i])) {
							if (recogerItem ()) {
								Destroy (hit.collider.gameObject); 
							}
						}
					}
				}
			}
		}
	}

	bool recogerItem () {
		for (int i = 0; i < jugadorBD.slots.Length; i++) {
			if (jugadorBD.slots [i] == "") {
				jugadorBD.slots [i] = hit.collider.tag;
				return true;
			}
		}
		return false;
	}

	void navegacion () {
		if (Input.GetAxisRaw ("Mouse ScrollWheel") < 0) {
			if (slotActual < (jugadorBD.slots.Length - 1)) {
				slotActual++;
				Debug.Log ("Aumenta por rueda");
			} else {
				slotActual = 0;
				Debug.Log ("Reinicia por rueda");
			}
		}
		if (Input.GetAxisRaw ("Mouse ScrollWheel") > 0) {
			if (slotActual > 0) {
				slotActual--;
				Debug.Log ("Disminuye por rueda");
			} else {
				slotActual = jugadorBD.slots.Length - 1;
				Debug.Log ("Maximo por rueda");
			}
		}
	}

	public bool itemActual (string item) {
		if (jugadorBD.slots [slotActual] == item) {
			return true;
		} else {
			return false;
		}
	}

	public Transform getInicioRayCast () {
		return inicioRayCast;
	}

	public RaycastHit getRaycastHit () {
		return hit;
	}

}
