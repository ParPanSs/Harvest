using UnityEngine;
using UnityEngine.SceneManagement;

public class CubesController : MonoBehaviour
{
    public float fallSpeed;
    public bool hasStarted;

    void Start()
    {
        fallSpeed /= 60f;
    }

    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, fallSpeed * Time.deltaTime, 0f);
        }
    }
}
