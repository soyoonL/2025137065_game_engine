using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public SpriteRenderer mapRenderer;

    private float cameraHalfWidth;
    private float cameraHalfHeight;
    private Vector2 minBounds;
    private Vector2 maxBounds;

    void Start()
    {
        Camera cam = Camera.main;
        cameraHalfHeight = cam.orthographicSize;
        cameraHalfWidth = cam.aspect * cameraHalfHeight;

        Bounds bounds = mapRenderer.bounds;
        minBounds = bounds.min;
        maxBounds = bounds.max;
    }

    void LateUpdate()
    {
        float x = Mathf.Clamp(player.position.x, minBounds.x + cameraHalfWidth, maxBounds.x - cameraHalfWidth);
        float y = Mathf.Clamp(player.position.y, minBounds.y + cameraHalfHeight, maxBounds.y - cameraHalfHeight);
        transform.position = new Vector3(x, y, transform.position.z);
    }

}
