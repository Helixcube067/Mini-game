using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement : MonoBehaviour
    {
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;

    public void MoveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ReturnScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void EndGame() 
        { 
        if (gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("game over");
                Invoke("ReturnScene", restartDelay);
            }
        }
    }
