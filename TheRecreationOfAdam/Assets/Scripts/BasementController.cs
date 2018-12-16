using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementController : MonoBehaviour {

    public GameObject[] clickableObjects;
    public GameObject[] objectsToAppear;
    public Animator animator;
    bool screwDriver;

 
    // Use this for initialization
    void Start()
    {
        screwDriver = false;
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
                        case "paintingButton":
                            //painting starts to move
                            animator.SetBool("movePainting", true);
                            break;
                        case "ScrewdriverSmall":
                            objectsToAppear[0].SetActive(true);
                            break;
                        case "screwdriverCloseUp":
                            objectsToAppear[1].SetActive(true);
                            screwDriver = true;
                            Destroy(clickableObjects[2]);
                            break;
                        case "wholeBox":
                            if (screwDriver)
                            {
                                objectsToAppear[2].SetActive(true);
                            }
                            else
                            {
                                objectsToAppear[5].SetActive(true);
                            }
                            break;
                        case "button":
                            Destroy(objectsToAppear[3]);
                            Destroy(objectsToAppear[4]);
                            objectsToAppear[6].SetActive(true);
                            break;
                    }
                }
            }
        }
    }
}
