using UnityEngine;

/// <summary>
/// 오브젝트 이동 컴포넌트 - 일정한 속도로 왼쪽으로 이동
/// </summary>
public class Mover : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Vector2 _moveDirection = Vector2.left;
    [SerializeField] private bool _normalizeDirection = true;

    private Vector2 _normalizedDirection;

    private void Awake()
    {
        CalculateDirection();
    }

    private void Update()
    {
        Move();
    }

    private void CalculateDirection()
    {
        _normalizedDirection = _normalizeDirection ? _moveDirection.normalized : _moveDirection;
    }

    private void Move()
    {
        transform.position += (Vector3)(_normalizedDirection * _moveSpeed * Time.deltaTime);
    }

    public void SetMoveSpeed(float speed)
    {
        _moveSpeed = Mathf.Max(0f, speed);
    }

    public void SetMoveDirection(Vector2 direction)
    {
        _moveDirection = direction;
        CalculateDirection();
    }

    private void OnValidate()
    {
        if (_moveSpeed < 0)
        {
            _moveSpeed = 0;
        }
        
        CalculateDirection();
    }
}
