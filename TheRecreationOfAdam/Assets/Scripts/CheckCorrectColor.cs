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
    public GameObject obj_to_destroy;
    public GameObject basement_door;



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
                else
                {
                    Button1 = false;
                }
            }
            else if (child.name == "Button2")
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
                if (childText.text == "3")
                {
                    Button3 = true;
                }
                else
                {
                    Button3 = false;
                }
            }
        }
        if (Button1 && Button2 && Button3)
        {
            Destroy(obj_to_destroy);
            door.SetActive(false);
            door_open.SetActive(true);
            basement_door.SetActive(true);
        }
    }

}
