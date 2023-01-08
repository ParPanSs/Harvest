using UnityEngine;

public class MakeBeesWork : MonoBehaviour
{
    private RestartBeat _restart;
    public Animator animator;
    public GameObject miniGamePrefab;
    public GameObject miniGameCopy;
    public Transform miniGameSpawnPoint;    
    private bool _isAboutBee;

    void Update()
    {
        Debug.Log(_restart.isDead);
        if (_isAboutBee && Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("isAnger", true);
            miniGameCopy = Instantiate(miniGamePrefab, miniGameSpawnPoint);
        }
        if(_restart.isDead)
            Destroy(miniGameCopy);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            _isAboutBee = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isAboutBee = false;
        }
    }

    private void Destruction()
    {
        Destroy(miniGameCopy);
    }
}
