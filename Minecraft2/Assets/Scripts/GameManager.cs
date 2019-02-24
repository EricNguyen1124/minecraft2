using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public void EndGame()
    {
        if (gameOver == false)
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            gameOver = true;
            Debug.Log("Game Over yeah");
            Invoke("Restart", 2);
            Score.score = 0;
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
