using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void ResumeGame()
    {
        InputDetector.pause = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
