using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // El transform del jugador
    public float smoothSpeed = 0.125f; // Velocitat de suavitzat (0 a 1)
    public Vector3 offset;        // Distància de separació entre càmera i jugador

    void LateUpdate()
    {
        if (target == null) return;

        // Calculem la posició desitjada
        Vector3 desiredPosition = target.position + offset;

        // Fem una transició suau entre la posició actual i la desitjada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apliquem la posició
        transform.position = smoothedPosition;
    }
}