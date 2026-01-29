using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int movementSpeed = 5;

    void Update()
    {
        // Move left or right
        transform.position += Input.GetAxis("Horizontal") * Vector3.right * movementSpeed * Time.deltaTime;

        // Set limits for movement
        if (transform.position.x > 2.5f)
        {
            transform.position = new Vector3(2.5f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -2.5f)
        {
            transform.position = new Vector3(-2.5f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Game Over
    }
}
