using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public Animator animator;
    private int levelToLoad;

    public GameObject InfoObject;
    public GameObject ObjectToDestroy;
    public GameObject objectInfoSprite;

	// Update is called once per frame
	void Update () 
    {
        //If left button is pushed
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                //If object called Interactive was clicked on, Fade to next level.
                if (hit.transform.name == "Interactive") FadeToNextLevel();
                if (hit.transform.name == "BlobBehind") BlobAppear();
            }
        }
    }

    public void FadeToNextLevel()
    {
        //Get the next scene to load
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    //For Library level where you click on book and it disappears
    //and behind the book is a color blob
    public void OnInfoObjectClicked()
    {
        objectInfoSprite.SetActive(true);
    }

    public void BlobAppear()
    {
        Destroy(ObjectToDestroy);
    }
}
