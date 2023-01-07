using UnityEngine;

public class RestartBeat : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Restart");
        //SceneManager.LoadScene(0);
    }
}
