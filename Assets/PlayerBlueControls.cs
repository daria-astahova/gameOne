using UnityEngine;

public class PlayerBlueControls : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of player movement
    public string horizontalAxis; // Input axis for horizontal movement (Z-axis)
    public string verticalAxis; // Input axis for vertical movement (X-axis)
    public Transform teleportObject; // Reference to the teleportation object
    public float teleportDistance = 5f; // Distance from the teleportation object for teleportation
    public ScoreManager ScoreManager; // Reference to the GameManager script for scoring
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component of the player
    }

    void Update()
    {
        // Relative movement to the camera
        Vector3 moveDirection = new Vector3(Input.GetAxis(verticalAxis), 0, -Input.GetAxis(horizontalAxis));
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0; // Prevent vertical movement
        moveDirection.Normalize(); // Normalize diagonal movement

        // Move the player
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == teleportObject)
        {
            // Teleport the player to the specified destination
            transform.position = new Vector3(9f, 0.5f, 0f);

            // Add score when the player teleports
           ScoreManager.Player2Scored();
        }
    }
}
