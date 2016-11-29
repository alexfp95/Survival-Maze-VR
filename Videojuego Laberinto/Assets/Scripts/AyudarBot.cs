using UnityEngine;
using System.Collections;

public class AyudarBot : MonoBehaviour {

	public AudioClip clipGracias;
	public AudioClip clipAqui;
	private AudioSource source;

	private GameObject scriptsContenedor;
	private Inventario inventario;
	private bool llorando;
	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;

	void Awake () {
		scriptsContenedor = GameObject.FindGameObjectWithTag ("Scripts");
		source = GetComponent<AudioSource> ();
		inventario = scriptsContenedor.GetComponent<Inventario> ();
		llorando = true;
		agent = GetComponent<NavMeshAgent>();
		agent.autoBraking = false;
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Player") {
			
		}
	}

	void OnCollisionStay (Collision other) {
		if (other.gameObject.tag == "Player") {
			if (inventario.itemActual ("Juguete")) {
				if ((Input.GetMouseButtonDown (0)) || (Input.GetAxis ("Fire1") != 0)) {
					Destroy (GameObject.FindGameObjectWithTag ("MuroInvisible"));
					Destroy (this.gameObject.GetComponent<Rigidbody> ());
					source.PlayOneShot (clipGracias, 0.5f);
					this.gameObject.GetComponent<Animator> ().Play ("Caminar");
					GotoNextPoint ();
					llorando = false;
				}
			}
		}
	}
		
	void GotoNextPoint() {
		if (points.Length == 0)
			return;

		agent.destination = points[destPoint].position;
		destPoint = destPoint + 1;
	}


	void Update () {
		if ((!llorando) && (destPoint < points.Length)) {
			if (agent.remainingDistance < 0.5f)
				GotoNextPoint ();
		}
		if ((destPoint == points.Length) && (agent.remainingDistance < 0.1f)){
			this.gameObject.GetComponent<Animator> ().Play ("Encontrado");
			source.PlayOneShot (clipAqui, 0.5f);
			Destroy (this.gameObject.GetComponent<NavMeshAgent> ());
			destPoint = destPoint + 1;
		}
	}
}
