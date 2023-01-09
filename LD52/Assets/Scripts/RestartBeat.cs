using UnityEngine;

public class RestartBeat : MonoBehaviour
{
    private MakeBeesWork _makeBeesWork;

    private void Start()
    {
        _makeBeesWork = GetComponentInParent<MakeBeesWork>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DeadZone"))
            _makeBeesWork.Destruction();
    }
}
