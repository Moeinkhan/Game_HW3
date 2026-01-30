using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    void Update()
    {
        transform.position -= Vector3.forward * speed * Time.deltaTime;

        // Destroy the Street if it goes out of the camera view
        if (transform.position.z < -50)
        {
            Destroy(gameObject);
        }
    }
}
