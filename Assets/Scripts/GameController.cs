using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public ParticleSystem particles1;
    public ParticleSystem particles2;
    public ParticleSystem particles3;
    public ParticleSystem particles4;


    // Use this for initialization
    void Start () {

        particles1.Simulate(1);
        particles2.Simulate(1);
        particles3.Simulate(1);
        particles4.Simulate(1);

    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(GetComponent<AudioSource>().time);


        if (GetComponent<AudioSource>().isPlaying && Input.GetButton("Fire1"))
        {
            Debug.Log(GetComponent<AudioSource>().time);
            particles1.Emit(1);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetButton("Fire2"))
        {
            Debug.Log(GetComponent<AudioSource>().time);
            particles2.Emit(1);
        }
        if (GetComponent<AudioSource>().isPlaying && Input.GetButton("Fire3"))
        {
            Debug.Log(GetComponent<AudioSource>().time);
            particles3.Emit(1);
        }
        //if (GetComponent<AudioSource>().isPlaying && Input.GetButton("Fire4"))
        //{
        //    particles4.Emit(1);
        // }

        if ((GetComponent<AudioSource>().time > 27 && GetComponent<AudioSource>().time < 27.25f)
            || (GetComponent<AudioSource>().time > 198 && GetComponent<AudioSource>().time < 198.058f)
            || (GetComponent<AudioSource>().time > 202.047 && GetComponent<AudioSource>().time < 202.09f)
            || (GetComponent<AudioSource>().time > 205.845 && GetComponent<AudioSource>().time < 205.599f)
            || (GetComponent<AudioSource>().time > 209.621 && GetComponent<AudioSource>().time < 209.877f)
            || (GetComponent<AudioSource>().time > 213.866 && GetComponent<AudioSource>().time < 214.314f)
            || (GetComponent<AudioSource>().time > 217.279 && GetComponent<AudioSource>().time < 217.535f)
            || (GetComponent<AudioSource>().time > 221.162 && GetComponent<AudioSource>().time < 221.567f)
            || (GetComponent<AudioSource>().time > 224.746 && GetComponent<AudioSource>().time < 225.045f)
            || (GetComponent<AudioSource>().time > 228.842 && GetComponent<AudioSource>().time < 229.183f)
            || (GetComponent<AudioSource>().time > 232.832 && GetComponent<AudioSource>().time < 233.109f)
            )
        {
            particles4.Emit(1);
        }



        if (GetComponent<AudioSource>().isPlaying && GetComponent<AudioSource>().time > 3 && !particles1.isPlaying)
        {
            var em = particles1.emission;
            em.rateOverTime = 0.1f;
            particles1.Play();
        }

        if (GetComponent<AudioSource>().isPlaying && GetComponent<AudioSource>().time > 45 && !particles2.isPlaying)
        {
            var em = particles1.emission;
            em.rateOverTime = 0.2f;

            var em2 = particles2.emission;
            em2.rateOverTime = 0.1f;

            particles2.Play();
        }

        if (GetComponent<AudioSource>().isPlaying && GetComponent<AudioSource>().time > 145 && !particles3.isPlaying)
        {
            var em2 = particles2.emission;
            em2.rateOverTime = 0.3f;

            particles3.Play();
        }

        if (GetComponent<AudioSource>().isPlaying && GetComponent<AudioSource>().time > 228 && !particles4.isPlaying)
        {
            var em1 = particles1.emission;
            em1.rateOverTime = 0.7f;

            var em2 = particles2.emission;
            em2.rateOverTime = 0.8f;

            var em3 = particles3.emission;
            em3.rateOverTime = 0.6f;

            particles4.Play();
        }

        if (!GetComponent<AudioSource>().isPlaying)
        {
            particles1.Stop();
            particles2.Stop();
            particles3.Stop();
            particles4.Stop();
        }


	}
}
