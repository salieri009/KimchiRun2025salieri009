using UnityEngine;
using System.Collections;

/// <summary>
/// 오브젝트 스포너 - 랜덤 간격으로 프리팹을 생성
/// 코루틴 기반으로 구현하여 더 안정적인 제어 가능
/// </summary>
public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private float _minSpawnDelay = 1f;
    [SerializeField] private float _maxSpawnDelay = 3f;
    [SerializeField] private bool _spawnOnStart = false;

    [Header("Prefab References")]
    [SerializeField] private GameObject[] _spawnPrefabs;

    private Coroutine _spawnCoroutine;
    private bool _isSpawning = false;

    private void OnEnable()
    {
        if (_spawnOnStart)
        {
            StartSpawning();
        }
    }

    private void OnDisable()
    {
        StopSpawning();
    }

    public void StartSpawning()
    {
        if (_isSpawning) return;

        _isSpawning = true;
        _spawnCoroutine = StartCoroutine(SpawnCoroutine());
    }

    public void StopSpawning()
    {
        _isSpawning = false;
        
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
            _spawnCoroutine = null;
        }
    }

    private IEnumerator SpawnCoroutine()
    {
        while (_isSpawning)
        {
            float delay = Random.Range(_minSpawnDelay, _maxSpawnDelay);
            yield return new WaitForSeconds(delay);
            
            SpawnRandomObject();
        }
    }

    private void SpawnRandomObject()
    {
        if (_spawnPrefabs == null || _spawnPrefabs.Length == 0)
        {
            Debug.LogWarning($"Spawner: No spawn prefabs assigned on {gameObject.name}");
            return;
        }

        GameObject prefabToSpawn = GetRandomPrefab();
        if (prefabToSpawn != null)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }

    private GameObject GetRandomPrefab()
    {
        // null이 아닌 프리팹만 필터링
        System.Collections.Generic.List<GameObject> validPrefabs = 
            new System.Collections.Generic.List<GameObject>();
        
        foreach (GameObject prefab in _spawnPrefabs)
        {
            if (prefab != null)
            {
                validPrefabs.Add(prefab);
            }
        }

        if (validPrefabs.Count == 0)
        {
            return null;
        }

        return validPrefabs[Random.Range(0, validPrefabs.Count)];
    }

    private void OnValidate()
    {
        // 에디터에서 값 검증
        if (_minSpawnDelay < 0)
        {
            _minSpawnDelay = 0;
        }

        if (_maxSpawnDelay < _minSpawnDelay)
        {
            _maxSpawnDelay = _minSpawnDelay;
        }
    }
}
