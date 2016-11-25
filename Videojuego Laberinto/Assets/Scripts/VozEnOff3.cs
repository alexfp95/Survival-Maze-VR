using UnityEngine;
using System.Collections;

public class VozEnOff3 : MonoBehaviour {

	public AudioClip clip;

	private AudioSource source;
	private bool played;

	void Awake () {
		source = GetComponent<AudioSource> ();
		played = false;
	}

	void OnTriggerEnter (Collider collider) {
		if (!played) {
			source.PlayOneShot (clip, 2f);
			played = true;
		}
	}

	void Update () {
		if (played && !source.isPlaying) {
			played = false;
		}
	}
}
