using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    private void Awake()
    {
        // La música sobreviva aunque se cambie de escena
        DontDestroyOnLoad(gameObject);
    }
}
