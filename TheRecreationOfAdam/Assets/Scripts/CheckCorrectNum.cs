using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCorrectNum : MonoBehaviour {
    public Animator anim;
    bool Button1 = false;
    bool Button2 = false;
    bool Button3 = false;
    bool Button4 = false;


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
            }
            else if(child.name == "Button2")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "2")
                {
                    Button2 = true;
                }
            }
            else if (child.name == "Button3")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "2")
                {
                    Button3 = true;
                }
            }
            else if (child.name == "Button4")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "7")
                {
                    Button4 = true;
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
    }
}