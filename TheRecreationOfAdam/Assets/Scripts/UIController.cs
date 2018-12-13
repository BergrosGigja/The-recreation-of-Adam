using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public Animator animator;
    private int levelToLoad;
    //static int hospitalCounter;
    //public GameObject Adam;
    //public GameObject point;
    //Vector3 pos;

    void Start()
    {
        //Adam = GameObject.FindGameObjectWithTag("Player");
        //point = GameObject.FindGameObjectWithTag("SpawnPoint"); 
        //pos = point.transform.position;   
    }

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
        /* if(levelToLoad == 1)
        {
            hospitalCounter ++;
        }
        Debug.Log("HopsitalCounter: " + hospitalCounter);
        if(hospitalCounter > 1 && levelToLoad == 1)
        {
            Debug.Log("Inside");
            Debug.Log("Adam Pos: " + Adam.transform.position);
            Debug.Log("Spawn pos: " + pos);
        }
        Debug.Log("levelToLoad: " + levelToLoad);*/
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

    public void NoKeyText(GameObject drawerText)
    {
        //Used for Hospital level
        drawerText.SetActive(true);
    }
}
