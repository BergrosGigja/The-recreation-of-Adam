using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToStart : MonoBehaviour {
    UIController _UIController;
    private float update;

    void Awake()
    {
        _UIController = FindObjectOfType<UIController>();
        update = 0.0f;
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
    }

    void Update()
    {
        update += Time.deltaTime;
        if (update > 20f)
        {
            _UIController.FadeToLevel(0);
        }
    }
}
