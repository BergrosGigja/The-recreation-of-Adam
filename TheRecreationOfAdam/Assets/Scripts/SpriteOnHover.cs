using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOnHover : MonoBehaviour {

    SpriteRenderer m_SpriteRenderer;
    Color m_MouseOverColor = Color.gray;
    Color m_OriginalColor;
    bool isClicked = false;

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
                if (hit.transform.name == "Book") {
                    _UIController.OnBookClicked();
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
