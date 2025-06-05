using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;

    public void RestartLevel()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}
