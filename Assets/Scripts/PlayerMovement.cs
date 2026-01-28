using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int movementSpeed = 5;

    void Update()
    {
        // Move left or right
        transform.position += Input.GetAxis("Horizontal") * Vector3.right * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Game Over
    }
}
