﻿using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {

    Rigidbody rigid;
    public GameObject explosion;
	//GameObject player;
	GameObject maincamera; // for player move script -- WHY???
	public int state;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponentInChildren<Rigidbody>();
		//player = GameObject.Find ("Knight");
		maincamera = GameObject.Find ("Main Camera");
		state = 0;
    }

    // Update is called once per frame
    void Update()
    {
		switch (state) {
		case 0:
			if (maincamera.GetComponent<MoveKnight>().start) {
				++state;
			}
			break;
		case 1:
			rigid.AddForce(Vector3.back * 10f);
			break;
		default:
			Debug.Log("MoveEnemy: Undefined state");
			break;
		}

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Main Camera")
        {
            rigid.constraints = RigidbodyConstraints.None;
            explosion.transform.position = collision.transform.position;
            Instantiate<GameObject>(explosion);
			Destroy (this.gameObject, 3);
        }
    }
}
