﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    private Quaternion angleoffset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
       // angleoffset = transform.rotation;

    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
	}
}
