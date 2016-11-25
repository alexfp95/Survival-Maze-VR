using UnityEngine;
using System.Collections;

public class MuroFalso : MonoBehaviour {

	public AudioClip clip;

	private AudioSource source;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			source.PlayOneShot (clip, 0.5f);
		}
	}

	void OnCollisionExit (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			source.Stop();
		}
	}
}
