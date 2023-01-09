using UnityEngine;

public class Phone : MonoBehaviour
{
    public Animator phone;
    public CircleCollider2D button;
    public GameObject lastCall;
    public Rigidbody2D rb;
    private bool _isPressed;
    public AudioSource phoneCall;

    private void OnTriggerEnter2D(Collider2D other)
    {
        phone.enabled = false;
        button.enabled = true;
        lastCall.SetActive(true);
        phoneCall.Stop();
    }

    private void OnTriggerExit2D(Collider2D other)
    { 
        Destroy(this);
    }
}
