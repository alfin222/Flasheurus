using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float lifeTime;
    bool gameHasEnded = false;
    float timeElapsed=0;

    void Update(){
        timeElapsed+=Time.deltaTime;
        if(timeElapsed>=lifeTime){
                FindObjectOfType<GameManager>().LoseGame();
        }
    }

    public void LoseGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAMEOVER");
            moveSceneLose();
        }
    }

    public void WinGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAMEOVER");
            moveSceneWin();
        }
    }

    void moveSceneLose(){
        SceneManager.LoadScene("GameOver");
    }

    void moveSceneWin(){
        SceneManager.LoadScene("Finished");
    }
}
