using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

    

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
        }
        else if (count > _numberOfParticles)
        { //particle has been born
            GetComponent<AudioSource>().Play();
        }

        _numberOfParticles = count;



    }
}
