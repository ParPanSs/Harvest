using UnityEngine;

public class CubesController : MonoBehaviour
{
    public float fallSpeed;

    void Start()
    {
        fallSpeed /= 60f;
    }

    void Update()
    {
        transform.position -= new Vector3(0f, fallSpeed * Time.deltaTime, 0f);
    }
}
