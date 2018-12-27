using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdamControllerScript : MonoBehaviour {

	Animator anim;
	Vector2 targetPos;
	Vector2 mouse;
    private float speed = 3f;

    public AudioSource audioS;

	void Start () {

		anim = GetComponent<Animator>();
		targetPos = transform.position;
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Basement_main") {
            transform.localScale = new Vector2(-1.0f, 1.0f);
        }
        
	}

    void FixedUpdate() {
        PlaySteps();
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
		}
    }

    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Wall") {
            anim.SetBool("walking", false);
            targetPos = new Vector2(transform.position.x, transform.position.y);
        }
    }

    void PlaySteps() {
        if (Vector2.Distance(targetPos, transform.position) > 0.2) {
            audioS.enabled = true;
            audioS.loop = true;
        } else {
            audioS.enabled = false;
            audioS.loop = false;
        }
    }
}

