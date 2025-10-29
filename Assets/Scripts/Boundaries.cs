using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public Vector2 minBounds; // bottom-left corner
    public Vector2 maxBounds; // top-right corner

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minBounds.x, maxBounds.x);
        pos.y = Mathf.Clamp(pos.y, minBounds.y, maxBounds.y);

        transform.position = pos;
    }

}

