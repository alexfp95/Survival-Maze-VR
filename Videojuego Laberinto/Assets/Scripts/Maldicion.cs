using UnityEngine;
using System.Collections;

public class Maldicion : MonoBehaviour {

	public AudioClip clip;
	private AudioSource source;

	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	public void escucharMaldicion () {
		source.PlayOneShot (clip, 0.5f);
	}
}
