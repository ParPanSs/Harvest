using UnityEngine;

public class RestartBeat : MonoBehaviour
{
    public bool isDead;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DeadZone"))
            isDead = true;
    }
}
