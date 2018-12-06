﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOnHover : MonoBehaviour {

    SpriteRenderer m_SpriteRenderer;
    Color m_MouseOverColor = Color.white;
    Color m_OriginalColor;
    bool isClicked = false;
    public GameObject bookInfo;
    UIController _UIController;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_OriginalColor = m_SpriteRenderer.color;
        _UIController = FindObjectOfType<UIController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                //If left clicked an object with name InfoObject
                //call the UIController's function to deploy text box
                if (hit.transform.name == "InfoObject")
                {
                    _UIController.OnInfoObjectClicked();
                }
                else if (hit.transform.name == "Interactive")
                {
                    _UIController.FadeToNextLevel();
                }
                else if (hit.transform.name == "BackToPrevLevel")
                {
                    _UIController.FadeToPrevLevel();
                }
                else if (hit.transform.name == "BlobBehind")
                {
                    _UIController.BlobAppear();
                }
                else if (hit.transform.name == "Book")
                {
                    bookInfo.SetActive(true);
                }
            }
        }
    }

    void OnMouseOver()
    {
        m_SpriteRenderer.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        m_SpriteRenderer.color = m_OriginalColor;
    }
}
