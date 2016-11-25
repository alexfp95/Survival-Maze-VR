using UnityEngine;
using System.Collections;

public class VozEnOff : MonoBehaviour {

	public AudioClip clip;

	private AudioSource source;
	private bool played;

	void Awake () {
		source = GetComponent<AudioSource> ();
		played = false;
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			if (!played) {
				source.PlayOneShot (clip, 2f);
				played = true;
			}
		}
	}

	void Update () {
		if (played && !source.isPlaying) {
			Destroy (this.gameObject);
		}
	}
}
