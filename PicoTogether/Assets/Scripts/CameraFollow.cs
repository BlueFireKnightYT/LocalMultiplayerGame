using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Vector2 offset;
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target1 == null || target2 == null) return;

        Vector3 middlePoint = (target1.position + target2.position) * 0.5f;

        Vector3 desiredPosition = new Vector3(
            middlePoint.x + offset.x,
            middlePoint.y + offset.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}
