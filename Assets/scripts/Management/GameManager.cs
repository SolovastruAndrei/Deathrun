using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;

    public float restartDelay = 2f;

    bool gameHasEnded = false;

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }
    public void GameOver()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke(nameof(Restart), restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
