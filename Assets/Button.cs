using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void LoadScene()
    {
        Debug.Log("Scene loaded");

        SceneManager.LoadScene("GameScene");
    }
    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }

}
