using UnityEngine;

public class JumpBlue : MonoBehaviour
{
    public float jumpForce = 10f; // Jump force for the blue player
    public string jumpButton; // Input button for jumping
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component of the player
    }

    void Update()
    {
        // Check if the player presses the jump button
        if (Input.GetButtonDown(jumpButton))
        {
            // Perform the jump action
            Jump();
        }
    }

    void Jump()
    {
        // Apply jump force
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
