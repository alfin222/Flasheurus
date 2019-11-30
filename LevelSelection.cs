using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{

    public void PlayLv1(){
        SceneManager.LoadScene("Level_01");
    }

    public void PlayLv2(){
        SceneManager.LoadScene("Level_02");
    }

}
