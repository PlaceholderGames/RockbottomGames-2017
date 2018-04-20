using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void ResumeGame()
    {
        InputDetector.pause = false;
        Cursor.visible = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadForest()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadHouse()
    {
        SceneManager.LoadScene(3);
    }
}
