using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;
    [SerializeField]
    private float acceleration = 0.05f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (gameManager.isGameOver)
            return;

        transform.position -= Vector3.forward * speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;

        // Move the street forward as the 3rd environment if it goes out of the camera view
        if (transform.position.z < -95)
        {
            transform.position += new Vector3(0, 0, 268.5f);
        }
    }
}
