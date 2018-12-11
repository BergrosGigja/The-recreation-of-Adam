using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobFollow : MonoBehaviour {

    public GameObject target;
    public float moveSpeed;
    Vector2 targetPos;
    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = target.transform.position;
        if (targetPos.y <= transform.position.y)
        {
            targetPos = new Vector2(targetPos.x, transform.position.y);
            if ((targetPos.x >= transform.position.x))
            {
                transform.localScale = new Vector2(1.0f, 1.0f);
            }
            else
            {
                transform.localScale = new Vector2(-1.0f, 1.0f);
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
 