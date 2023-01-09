using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titles : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Menu());
    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(0);
    }
}
