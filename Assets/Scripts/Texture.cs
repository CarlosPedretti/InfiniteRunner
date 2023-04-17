using UnityEngine;

public class Texture : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        float offset = Time.time * scrollSpeed;
        renderer.material.mainTextureOffset = new Vector2(0, -offset);
    }
}