using System;
using System.Collections;
using UnityEngine;

public class MakeBeesWork : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Animator beeAnimator;
    public GameObject miniGamePrefab;
    public GameObject miniGameCopy;
    private bool _isAboutBee;
    private bool _isMiniGame;
    public Animator machineAnimator;
    [SerializeField] private float _secondsToIDLE;
    private bool _isBeeLazy = true;

    public Animator timer;

    void Update()
    {
        if (_isAboutBee && Input.GetKeyDown(KeyCode.E) && _isBeeLazy)
        {
            miniGameCopy = Instantiate(miniGamePrefab, gameObject.transform, false);
            animator.SetBool("isAnger", true);
            rb.bodyType = RigidbodyType2D.Static;
        }
    }

    public void Success()
    {
        Destroy(miniGameCopy);        
        rb.bodyType = RigidbodyType2D.Dynamic;
        animator.SetBool("isAnger", false);
        _isBeeLazy = false;
        beeAnimator.SetBool("Working", true);
        machineAnimator.enabled = true;
        timer.SetBool("ticking", true);
        StartCoroutine(BackToIDLE());
    }
    public void Destruction()
    {
        Destroy(miniGameCopy);
        animator.SetBool("isAnger", false);
        rb.bodyType = RigidbodyType2D.Dynamic;
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

    IEnumerator BackToIDLE()
    {
        yield return new WaitForSeconds(_secondsToIDLE);        
        timer.SetBool("ticking", false);
        _isBeeLazy = true;
        beeAnimator.SetBool("Working", false);
        machineAnimator.enabled = false;
    }
}
