using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkController : MonoBehaviour {

    public AudioClip boom;
    public AudioClip crackle;

    private int _numberOfParticles = 0;

    // Use this for initialization
    void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        ParticleSystem ps = GetComponent<ParticleSystem>();

        var count = ps.particleCount;

        if (count < _numberOfParticles)
        { //particle has died
            //audioSource.PlayOneShot(clip);
            GetComponent<AudioSource>().clip = crackle;
            GetComponent<AudioSource>().Play();
        }
        else if (count > _numberOfParticles)
        { //particle has been born
            GetComponent<AudioSource>().clip = boom;
            GetComponent<AudioSource>().PlayDelayed(0.15f);
        }

        _numberOfParticles = count;



    }
}
