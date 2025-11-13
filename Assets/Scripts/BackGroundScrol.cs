using UnityEngine;

/// <summary>
/// 배경 스크롤 효과 - 텍스처 오프셋을 조정하여 무한 스크롤 효과 생성
/// </summary>
public class BackGroundScroll : MonoBehaviour
{
    [Header("Scroll Settings")]
    [Tooltip("The speed of the scrolling background")]
    [SerializeField] private float _scrollSpeed = 0.1f;
    [SerializeField] private Vector2 _scrollDirection = Vector2.right;

    [Header("References")]
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Material _materialInstance;

    private void Awake()
    {
        ValidateComponents();
        CreateMaterialInstance();
    }

    private void Update()
    {
        ScrollBackground();
    }

    private void ValidateComponents()
    {
        if (_meshRenderer == null)
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            
            if (_meshRenderer == null)
            {
                Debug.LogError($"BackGroundScroll: MeshRenderer component not found on {gameObject.name}");
            }
        }
    }

    private void CreateMaterialInstance()
    {
        // 머티리얼 인스턴스를 생성하여 다른 오브젝트에 영향을 주지 않도록 함
        if (_meshRenderer != null && _meshRenderer.material != null)
        {
            _materialInstance = _meshRenderer.material;
        }
    }

    private void ScrollBackground()
    {
        if (_materialInstance != null)
        {
            Vector2 offset = _scrollDirection * _scrollSpeed * Time.deltaTime;
            _materialInstance.mainTextureOffset += offset;
        }
    }

    public void SetScrollSpeed(float speed)
    {
        _scrollSpeed = speed;
    }

    public void SetScrollDirection(Vector2 direction)
    {
        _scrollDirection = direction.normalized;
    }

    private void OnDestroy()
    {
        // 인스턴스 머티리얼 정리 (필요한 경우)
        // Material 인스턴스는 Unity가 자동으로 관리하지만, 명시적으로 정리할 수도 있음
    }
}
