using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("The speed of the scrolling background")]
    public float scrollSpeed = 0.1f;

    [Header("references")]
    public MeshRenderer meshRenderer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
