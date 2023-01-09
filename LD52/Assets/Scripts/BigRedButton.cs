using UnityEngine;
using UnityEngine.SceneManagement;

public class BigRedButton : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(2);
    }
}
