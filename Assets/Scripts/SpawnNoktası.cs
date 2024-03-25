using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnNoktası : MonoBehaviour
{
    // Spawn edilecek prefab listesi
    public List<GameObject> prefabsToSpawn = new List<GameObject>();

    // Minimum ve maksimum spawn aralığı (saniye cinsinden)
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 5f;

    // Zaman sayacı
    private float timer = 0f;
    private float wait_time = 0f;
    void Update()
    {
        // Zaman sayacını artır
        timer += Time.deltaTime;
        
        // Belirlenen spawn aralığına ulaşıldığında
        if (timer >=  wait_time)
        {
            wait_time = Random.Range(minSpawnInterval, maxSpawnInterval);
            // Rastgele bir prefab seç
            GameObject prefabToSpawn = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Count)];

            // Seçilen prefabı spawn et
            Instantiate(prefabToSpawn, transform.position, transform.rotation);

            // Zaman sayacını sıfırla
            timer = 0f;
        }
    }
}
