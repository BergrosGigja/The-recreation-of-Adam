using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public Animator animator;
    private int levelToLoad;

    public void FadeToNextLevel()
    {
        //Get the next scene to load
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToPrevLevel()
    {
        //Get the next scene to load
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
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
    public void OnHoverObjectClicked(GameObject objectToAppear)
    {
        objectToAppear.SetActive(true);
    }

    public void BlobAppear(GameObject objectToDestroy,GameObject ObjectToAppear)
    {
        Destroy(objectToDestroy);
        ObjectToAppear.SetActive(true);
    }
}
