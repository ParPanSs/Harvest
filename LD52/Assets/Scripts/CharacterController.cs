using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;

    [SerializeField] private float speed;
    private float _horizontalMove;

    private bool _isFacingRight = true;
    

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _horizontalMove = Input.GetAxis("Horizontal") * speed;
        if (_rb.velocity.x != 0)
        {
            _animator.SetBool("isWalk", true);
        }
        else
        {
            _animator.SetBool("isWalk", false);
        }
        
        
        Flip();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_horizontalMove, _rb.velocity.y);
    }
    
    private void Flip()
    {
        if (_isFacingRight && _horizontalMove < 0 || !_isFacingRight && _horizontalMove > 0)
        {
            Vector3 localScale = transform.localScale;
            _isFacingRight = !_isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    
}
