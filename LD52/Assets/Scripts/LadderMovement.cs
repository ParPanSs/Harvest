using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;
    
    [SerializeField] private float _speed;
    private float _vertical;
    
    private bool _isClimbing;
    private bool _inLadder;
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _vertical = Input.GetAxis("Vertical") * _speed;

        if (_inLadder && Mathf.Abs(_vertical) > 0f)
        {
            _isClimbing = true;
        }
        
        if(_isClimbing)
            _animator.SetBool("isClimbing", true);
        else
            _animator.SetBool("isClimbing", false);
    }

    private void FixedUpdate()
    {
        if (_inLadder)
        {
            _rb.gravityScale = 0f;
            if(_isClimbing)
                _rb.velocity = new Vector2(_rb.velocity.x, _vertical);
        }
        else
        {
            _rb.gravityScale = 5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ladder"))
        {
            _inLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            _inLadder = false;
            _isClimbing = false;
        }
    }
}
