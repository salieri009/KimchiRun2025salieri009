using UnityEngine;

/// <summary>
/// 화면 밖으로 나간 오브젝트를 제거하는 컴포넌트
/// 오브젝트 풀링 시스템과 통합 가능하도록 설계
/// </summary>
public class Destroyer : MonoBehaviour
{
    [Header("Destroy Settings")]
    [SerializeField] private float _destroyXThreshold = GameConstants.DESTROY_X_THRESHOLD;
    [SerializeField] private bool _checkYAxis = false;
    [SerializeField] private float _destroyYThreshold = -10f;

    private void Update()
    {
        CheckAndDestroy();
    }

    private void CheckAndDestroy()
    {
        Vector3 position = transform.position;
        
        bool shouldDestroy = position.x < _destroyXThreshold;
        
        if (_checkYAxis)
        {
            shouldDestroy = shouldDestroy || position.y < _destroyYThreshold;
        }

        if (shouldDestroy)
        {
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        // TODO: 오브젝트 풀링 시스템과 통합 시 여기서 풀로 반환
        // ObjectPool.Instance.ReturnToPool(gameObject);
        
        Destroy(gameObject);
    }

    public void SetDestroyThreshold(float xThreshold, float yThreshold = float.MinValue)
    {
        _destroyXThreshold = xThreshold;
        
        if (yThreshold != float.MinValue)
        {
            _destroyYThreshold = yThreshold;
            _checkYAxis = true;
        }
    }
}
