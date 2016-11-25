using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Desbloqueo : MonoBehaviour {

	public AudioClip clipError;
	public AudioClip clipDesbl;
	private AudioSource source;

	string clave;
	string secuencia;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void Start () {
		clave = "A101N";
		secuencia = "";
	}

	public void insertar (string d) {
		if (secuencia.Length != clave.Length) {
			secuencia = secuencia + d;
			Debug.Log ("Secuencia: " + secuencia);
		}
	}

	void Update () {
		if (secuencia.Length == clave.Length) {
			if (clave.Equals (secuencia)) {
				source.PlayOneShot (clipDesbl, 0.5f);
				secuencia = "";
				System.Threading.Thread.Sleep (1463);
				SceneManager.LoadScene ("Creditos");
			} else {
				secuencia = secuencia + "x";
				source.PlayOneShot (clipError, 0.5f);
			}
		} 
	}

	public void reset () {
		secuencia = "";
		GameObject[] pulsadores = GameObject.FindGameObjectsWithTag ("Pulsador");
		foreach (GameObject p in pulsadores) {
			p.GetComponent<Pulsador> ().reset ();
		}
	}
		
}
