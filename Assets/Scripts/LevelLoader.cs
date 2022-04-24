using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntToLoadLevel = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "boy2")
        {
           LoadScene();
            
        }
    }

    void LoadScene()
    {
        /* if (useIntToLoadLevel)
         {
             SceneManager.LoadScene(iLevelToLoad);
         }
         else
         {
             SceneManager.LoadScene(sLevelToLoad);
         }*/

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
