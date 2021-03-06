﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetViewController : MonoBehaviour
{
    public GameObject[] clickableObjects;
    public GameObject[] objectsToAppear;
    UIController _UIController;
    // Use this for initialization
    void Start()
    {
        _UIController = FindObjectOfType<UIController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            foreach (var obj in clickableObjects)
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name)
                    {
                        case "hospital_door":
                            //nurse smoking text appears
                            objectsToAppear[1].SetActive(true);
                            break;
                        case "library_door":
                            //go to library view
                            _UIController.FadeToLevel(3);
                            break;
                        case "museum_door":
                            //key_text appears
                            objectsToAppear[0].SetActive(true);
                            break;
                    }
                }
            }
        }
    }
}
