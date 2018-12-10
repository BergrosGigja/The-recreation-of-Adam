﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour
{

    SpriteRenderer m_SpriteRenderer;
    Color m_MouseOverColor = Color.white;
    Color m_OriginalColor;
    public GameObject ObjectToAppear;
    UIController _UIController;
    BoxCollider2D m_boxCollider;
    // Use this for initialization
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_OriginalColor = m_SpriteRenderer.color;
        _UIController = FindObjectOfType<UIController>();
        m_boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null && hit.collider == m_boxCollider)
            {
                //Debug.Log(transform.name + " // " + hit.collider.name);
                _UIController.OnHoverObjectClicked(ObjectToAppear);
            }
            else if(hit.collider != null && hit.collider.name == "BlobBehind")
            {
                _UIController.BlobAppear(gameObject, ObjectToAppear);
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
