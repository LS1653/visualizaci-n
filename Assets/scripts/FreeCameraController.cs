using UnityEngine;

public class FreeCameraController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 1000f;
    [SerializeField] private float smoothSpeed = 10f;

    [Header("Map Limits")]
    [SerializeField] private float minX = -500f;
    [SerializeField] private float maxX = 500f;
    [SerializeField] private float minZ = -500f;
    [SerializeField] private float maxZ = 500f;

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void LateUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.D)) move += Vector3.forward;
        if (Input.GetKey(KeyCode.A)) move += Vector3.back;
        if (Input.GetKey(KeyCode.W)) move += Vector3.left;
        if (Input.GetKey(KeyCode.S)) move += Vector3.right;

        targetPosition += move * moveSpeed * Time.deltaTime;

        ClampToBounds();

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }

    void ClampToBounds()
    {
        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
        targetPosition.z = Mathf.Clamp(targetPosition.z, minZ, maxZ);
    }
}
