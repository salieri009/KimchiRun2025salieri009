using UnityEngine;
using System.Collections;

/// <summary>
/// 플레이어 컨트롤러 - 점프, 충돌, 생명력, 무적 상태 관리
/// </summary>
public class Player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private float _groundCheckDistance = 0.1f;
    [SerializeField] private LayerMask _groundLayerMask = 1; // Default layer

    [Header("Health Settings")]
    [SerializeField] private int _maxLives = GameConstants.MAX_LIVES;
    [SerializeField] private float _invincibleDuration = GameConstants.INVINCIBLE_DURATION;

    [Header("Component References")]
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private BoxCollider2D _collider;
    [SerializeField] private Transform _groundCheckPoint;

    private int _currentLives;
    private bool _isGrounded;
    private bool _isInvincible;
    private Coroutine _invincibleCoroutine;

    public int CurrentLives => _currentLives;
    public bool IsGrounded => _isGrounded;
    public bool IsInvincible => _isInvincible;

    private void Awake()
    {
        ValidateComponents();
        InitializePlayer();
    }

    private void Start()
    {
        _currentLives = _maxLives;
        GameEvents.NotifyPlayerLivesChanged(_currentLives);
    }

    private void Update()
    {
        CheckGrounded();
        HandleJumpInput();
    }

    private void ValidateComponents()
    {
        if (_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            if (_rigidbody == null)
            {
                Debug.LogError($"Player: Rigidbody2D component not found on {gameObject.name}");
            }
        }

        if (_animator == null)
        {
            _animator = GetComponent<Animator>();
        }

        if (_collider == null)
        {
            _collider = GetComponent<BoxCollider2D>();
            if (_collider == null)
            {
                Debug.LogError($"Player: BoxCollider2D component not found on {gameObject.name}");
            }
        }

        if (_groundCheckPoint == null)
        {
            GameObject groundCheck = new GameObject("GroundCheck");
            groundCheck.transform.SetParent(transform);
            groundCheck.transform.localPosition = Vector3.zero;
            _groundCheckPoint = groundCheck.transform;
        }
    }

    private void InitializePlayer()
    {
        _isGrounded = true;
        _isInvincible = false;
    }

    private void CheckGrounded()
    {
        Vector2 checkPosition = _groundCheckPoint.position;
        _isGrounded = Physics2D.Raycast(checkPosition, Vector2.down, _groundCheckDistance, _groundLayerMask);
    }

    private void HandleJumpInput()
    {
        if (Input.GetKeyDown(GameConstants.JUMP_KEY) && _isGrounded && _rigidbody != null)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        _isGrounded = false;
        SetAnimationState(GameConstants.ANIM_STATE_JUMP);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GameConstants.TAG_PLATFORM))
        {
            HandleLanding();
        }
    }

    private void HandleLanding()
    {
        if (!_isGrounded)
        {
            SetAnimationState(GameConstants.ANIM_STATE_LAND);
        }
        _isGrounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(GameConstants.TAG_ENEMY))
        {
            HandleEnemyCollision(collision.gameObject);
        }
        else if (collision.CompareTag(GameConstants.TAG_FOOD))
        {
            HandleFoodCollision(collision.gameObject);
        }
        else if (collision.CompareTag(GameConstants.TAG_GOLDEN))
        {
            HandleGoldenCollision(collision.gameObject);
        }
    }

    private void HandleEnemyCollision(GameObject enemy)
    {
        if (!_isInvincible)
        {
            TakeDamage();
        }
    }

    private void HandleFoodCollision(GameObject food)
    {
        if (food != null)
        {
            Destroy(food);
            Heal();
        }
    }

    private void HandleGoldenCollision(GameObject golden)
    {
        if (golden != null)
        {
            Destroy(golden);
            StartInvincibility();
        }
    }

    public void TakeDamage()
    {
        if (_isInvincible) return;

        _currentLives = Mathf.Max(0, _currentLives - 1);
        GameEvents.NotifyPlayerLivesChanged(_currentLives);

        if (_currentLives <= 0)
        {
            Die();
        }
        else
        {
            // 피해를 받았을 때 짧은 무적 시간 (선택사항)
            StartInvincibility(0.5f);
        }
    }

    public void Heal()
    {
        int previousLives = _currentLives;
        _currentLives = Mathf.Min(_maxLives, _currentLives + 1);
        
        if (_currentLives > previousLives)
        {
            GameEvents.NotifyPlayerHealed();
            GameEvents.NotifyPlayerLivesChanged(_currentLives);
        }
    }

    public void StartInvincibility(float duration = -1f)
    {
        if (duration < 0)
        {
            duration = _invincibleDuration;
        }

        if (_invincibleCoroutine != null)
        {
            StopCoroutine(_invincibleCoroutine);
        }

        _invincibleCoroutine = StartCoroutine(InvincibilityCoroutine(duration));
    }

    private IEnumerator InvincibilityCoroutine(float duration)
    {
        _isInvincible = true;
        GameEvents.NotifyPlayerInvincibleStarted();

        yield return new WaitForSeconds(duration);

        _isInvincible = false;
        GameEvents.NotifyPlayerInvincibleEnded();
        _invincibleCoroutine = null;
    }

    private void Die()
    {
        if (_collider != null)
        {
            _collider.enabled = false;
        }

        if (_animator != null)
        {
            _animator.enabled = false;
        }

        if (_rigidbody != null)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

        GameEvents.NotifyPlayerDied();
        
        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver();
        }
    }

    private void SetAnimationState(int state)
    {
        if (_animator != null)
        {
            _animator.SetInteger("State", state);
        }
    }

    private void OnDestroy()
    {
        if (_invincibleCoroutine != null)
        {
            StopCoroutine(_invincibleCoroutine);
        }
    }
}
