﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCorrectNum : MonoBehaviour {
    Animator anim;
    bool Button1 = false;
    bool Button2 = false;
    bool Button3 = false;
    bool Button4 = false;
    bool allCorrect = false;
    public GameObject objToDestroy;
    public GameObject boxLid;
    public GameObject blob;
    public GameObject blobOnClose;
    public GameObject door;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        foreach(Transform child in transform)
        {
            if(child.name == "Button1")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "2")
                {
                    Button1 = true;
                }
                else
                {
                    Button1 = false;
                }
            }
            else if(child.name == "Button2")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "2")
                {
                    Button2 = true;
                }
                else
                {
                    Button2 = false;
                }
            }
            else if (child.name == "Button3")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "2")
                {
                    Button3 = true;
                }
                else
                {
                    Button3 = false;
                }
            }
            else if (child.name == "Button4")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "7")
                {
                    Button4 = true;
                }
                else
                {
                    Button4 = false;
                }
            }
        }
        if(Button1 && Button2 && Button3 && Button4)
        {
            StartAnimation();
        }
	}
    void StartAnimation()
    {
        anim.SetBool("Open", true);
        boxLid.SetActive(true);
        blob.SetActive(true);
        Destroy(objToDestroy);
        allCorrect = true;
        door.SetActive(true);
    }

    public void CheckIfBlobAppears()
    {
        if(allCorrect)
        {
            blobOnClose.SetActive(true);
        }
    }
}