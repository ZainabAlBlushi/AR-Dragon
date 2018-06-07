using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    private ParticleSystem pps;

	// Use this for initialization
	void Start () {
        pps = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartFire(){
        pps.Play();
    }

    public void StopFire()
    {
        pps.Stop();
    }
}
