using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 2.0f;
    public float rotationSpeed = 10f;
    public Camera mainCamera;  // Assign this in the inspector

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction relative to the camera's rotation
        Vector3 forward = mainCamera.transform.forward;
        Vector3 right = mainCamera.transform.right;

        // Remove any vertical component from the camera's forward and right vectors
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = forward * moveVertical + right * moveHorizontal;
        desiredMoveDirection.Normalize();

        // Move the character
        rb.AddForce(desiredMoveDirection * speed);

        // Infinite jumps
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Rotate the character to face the movement direction
        if (desiredMoveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(desiredMoveDirection, Vector3.up);
            rb.rotation = Quaternion.Lerp(rb.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
