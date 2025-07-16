using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject PlatformPrefab;
    
    [SerializeField] private int amountOfPlatforms; 
    [SerializeField] private float levelWidth;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPosition = new Vector3(); 

        for (int i = 0; i < amountOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(PlatformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
