using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    
    public Animator animator;
    private int levelToLoad;

    public GameObject book;
    public GameObject objectInfoText;

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Interactive") FadeToNextLevel();
            }
        }
    }

    public void FadeToNextLevel()
    {
        Debug.Log("Your active scene is: " + SceneManager.GetActiveScene().buildIndex);
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        Debug.Log("Your scene to load is: " + levelToLoad);
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        Debug.Log("Fade has completed");

        SceneManager.LoadScene(levelToLoad);
    }

    public void OnBookClicked()
    {
        Destroy(book);
        Debug.Log("Book has been destroyed");
        objectInfoText.SetActive(true);
    }
}
