using UnityEngine;

public class StopMenuMusic : MonoBehaviour
{
    void Start()
    {
        GameObject menuMusic = GameObject.Find("MusicManager");
        if (menuMusic != null)
        {
            Destroy(menuMusic);
        }
    }
}
