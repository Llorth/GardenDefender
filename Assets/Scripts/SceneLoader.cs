using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int _sceneIndex;
    [SerializeField]private int timeToWait = 4;
    void Start()
    {
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (_sceneIndex ==0)
        {
            StartCoroutine( LoadStartScene());
        }
       
    }

    IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(_sceneIndex + 1);

    }
    
}
    
        
    

    
