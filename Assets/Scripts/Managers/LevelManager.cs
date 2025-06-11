using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;
    public GameObject collectablePrefab;
    public List<GameObject> collectables;

    public void RestartLevel()
    {
        DeazctivateDoor();
        RandomizeDoorPosition();
        DeleteCollectables();
        GenerateCoolectables();
    }

    private void DeleteCollectables()
    {
        foreach (GameObject c in collectables)
        {
            Destroy(c.gameObject);
        }
        collectables.Clear();
    }

    private void GenerateCoolectables()
    {
        var newCollectable = Instantiate(collectablePrefab);
        newCollectable.transform.position = new Vector3(Random.Range(2.2f, 10f), 0, Random.Range(-11f, 0f));
        collectables.Add(newCollectable);
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(3.3f, 9.6f);
        door.transform.position = pos;
    }

    private void DeazctivateDoor()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}
