using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobFollow : MonoBehaviour {

    public GameObject target;
    public float moveSpeed;
    Vector2 targetPos;
    Vector2 blobPos;
    bool right;
    // Use this for initialization
    void Start()
    {
        blobPos = transform.position;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = target.transform.position;
        if(right)
        {
            blobPos = new Vector2(targetPos.x - 1.5f, transform.position.y);
        }
        else
        {
            blobPos = new Vector2(targetPos.x + 1.5f, transform.position.y);
        }

        if ((blobPos.x >= transform.position.x))
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
            right = false;
        }
        else
        {
            transform.localScale = new Vector2(-1.0f, 1.0f);
            right = true;
        }

        transform.position = Vector2.MoveTowards(transform.position, blobPos, moveSpeed * Time.deltaTime);
    }
}
