﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.GetComponent<Collider2D>().tag == "Warp") {

			CorpseButton.warpTarget_current = coll.gameObject.transform;
		}
	}
}
