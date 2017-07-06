using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {

		public AudioClip audioClip1;
    private AudioSource audioSource;
    private ParticleSystem particle;

	// Use this for initialization
	void Start () {
	particle = this.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {

				audioSource = gameObject.GetComponent<AudioSource>();
        


}
	void OnCollisionEnter(Collision collision){
  			audioSource.clip = audioClip1;
        audioSource.Play ();
        particle.Play ();
}

}