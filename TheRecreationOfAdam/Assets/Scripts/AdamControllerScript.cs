using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamControllerScript : MonoBehaviour {

	Animator anim;
	Vector2 targetPos;
	Vector2 mouse;
    private float speed = 3f;

	void Start () {

		anim = GetComponent<Animator>();
		targetPos = transform.position;
	}

	void Update () {
        if (Input.GetMouseButton(0)) {
            mouse = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mouse.y <= transform.position.y) {
                targetPos = new Vector2(mouse.x, transform.position.y);
                if ((targetPos.x >= transform.position.x)) {
                    transform.localScale = new Vector2(1.0f, 1.0f);
                }
                else {
                    transform.localScale = new Vector2(-1.0f, 1.0f);
                }
            }
        }
        if (Vector2.Distance(targetPos, transform.position) > 0.2) {
			anim.SetBool("walking", true);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        } else {
			anim.SetBool("walking", false);
            //FindObjectOfType<AudioManager>().Play("Walking");
		}
    }

    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Wall") {
            anim.SetBool("walking", false);
            targetPos = new Vector2(transform.position.x, transform.position.y);
        }
    }
}

