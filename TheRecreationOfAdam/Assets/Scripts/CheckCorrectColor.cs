using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCorrectColor : MonoBehaviour {
    bool Button1 = false;
    bool Button2 = false;
    bool Button3 = false;
    public GameObject door;
    public GameObject door_open;


	// Update is called once per frame
	void Update () {
        foreach (Transform child in transform)
        {
            if (child.name == "Button1")
            {
                TextMeshProUGUI childText = child.GetComponentInChildren<TextMeshProUGUI>();
                if (childText.text == "3")
                {
                    Button1 = true;
                }
            }
            else if (child.name == "Button2")
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
                if (childText.text == "3")
                {
                    Button3 = true;
                }
            }
        }
        if (Button1 && Button2 && Button3)
        {
            Destroy(this.gameObject);
            door.SetActive(false);
            door_open.SetActive(true);
        }
    }

}
