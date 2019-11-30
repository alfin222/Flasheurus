using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameCtrl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("y") || Input.GetKey("return")){
            string sceneName = PlayerPrefs.GetString("lastLoadedScene");
            SceneManager.LoadScene(sceneName);
        }

        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("MainMenu");
        }
    }
}
