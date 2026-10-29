using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 1, -10);

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        // Player ගේ පිහිටීමට offset එක එකතු කර කැමරාව යා යුතු තැන සෙවීම
        Vector3 desiredPosition = target.position + offset;

        // SmoothDamp මඟින් සුමටව කැමරාව ගමන් කරවීම
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        transform.position = smoothedPosition;
    }
}