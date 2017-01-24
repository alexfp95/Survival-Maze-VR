using UnityEngine;
using System.Collections;

public class Pulsador : MonoBehaviour {

	public AudioClip clip;
	private AudioSource source;

	public string code;
	bool active;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}

	void Start () {
		active = false;
	}

	public void push () {
		if (!active) {
			if (this.gameObject.tag == "Reset") {
				GameObject.FindGameObjectWithTag ("PuertaSalida").GetComponent<Desbloqueo> ().reset ();
			} else {
				source.PlayOneShot (clip, 0.5f);
				active = true;
				transform.Rotate (180, 0, 0);
				GameObject.FindGameObjectWithTag ("PuertaSalida").GetComponent<Desbloqueo> ().insertar (code);
			}
		}
	}

	public bool isActive () {
		return active;
	}

	public void reset () {
		if (active) {
			active = false;
			transform.Rotate (180, 0, 0);
		}
	}
}
