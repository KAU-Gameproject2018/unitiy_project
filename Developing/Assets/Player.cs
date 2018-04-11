using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int HealthPoint = 100;

	private int InitHp;
	private int EnergyPoint;


	// Use this for initialization
	void Start () {
		InitHp = HealthPoint;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (HealthPoint < 0)
			PlayerDie ();
	}

	void PlayerDie () {
		//Destroy (GameObject);
	}
}
