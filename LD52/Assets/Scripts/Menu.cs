using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject play;
    public GameObject exit;
    public bool playFrame = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            playFrame = !playFrame;
            exit.SetActive(playFrame);
            play.SetActive(!playFrame);
        }

        if (play.activeInHierarchy && Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(1);
        if (exit.activeInHierarchy && Input.GetKeyDown(KeyCode.Return))
            Application.Quit();
    }
}
