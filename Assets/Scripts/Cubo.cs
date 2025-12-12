using UnityEngine;

public class FallingCube : MonoBehaviour
{
    GameManager3D gm;

    void Start()
    {
        gm = FindObjectOfType<GameManager3D>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.AddScore();
            Destroy(gameObject);
        }
        else if (other.CompareTag("Ground"))
        {
            gm.LoseLife();
            Destroy(gameObject);
        }
    }
}
