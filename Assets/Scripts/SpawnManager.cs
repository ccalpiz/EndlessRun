using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    private PlayerController playerController;

    void Start()
    {
        var go = GameObject.Find("Player");
        playerController = go.GetComponent<PlayerController>();
        InvokeRepeating("Spawn", 1, 3);
    }

    void Spawn()
    {
        if (playerController.isGameOver == false)
        {
            Instantiate(
                obstaclePrefab,
                spawnPoint.position,
                obstaclePrefab.transform.rotation
            );
        }
    }
}
