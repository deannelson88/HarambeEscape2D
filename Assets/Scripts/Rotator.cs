﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector2(15, 30) * Time.deltaTime);
	}
}
