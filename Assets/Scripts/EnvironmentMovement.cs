using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    void Update()
    {
        transform.position -= Vector3.forward * speed * Time.deltaTime;

        // Move the street forward as the 3rd environment if it goes out of the camera view
        if (transform.position.z < -95)
        {
            transform.position += new Vector3(0, 0, 268.5f);
        }
    }
}
