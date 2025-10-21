using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
