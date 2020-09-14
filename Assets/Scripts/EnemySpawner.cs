using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyprefabs;
    float maxspawnsec = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnPlanet", maxspawnsec);
        InvokeRepeating("IncreaseDifficulty", 0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnPlanet()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anenemy = (GameObject)Instantiate(enemyprefabs);
        anenemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
        NextPlanet();
    }
    void NextPlanet()
    {
        float SpawnInsec;
        if (maxspawnsec > 1f)
        {
            SpawnInsec = Random.Range(1f, maxspawnsec);
        }
        else
            SpawnInsec = 1f;
        Invoke("SpawnPlanet", SpawnInsec);
    }
    void IncreaseDifficulty()
    {
        if (maxspawnsec > 1f)
        {
            maxspawnsec--;
        }
        if (maxspawnsec == 1f)
        {
            CancelInvoke("IncreaseDifficulty");
        }
    }
}
