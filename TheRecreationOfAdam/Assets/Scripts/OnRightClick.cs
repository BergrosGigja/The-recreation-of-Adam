﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRightClick : MonoBehaviour {
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.SetActive(false);
        }
    }
}
