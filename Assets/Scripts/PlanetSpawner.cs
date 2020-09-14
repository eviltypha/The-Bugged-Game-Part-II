using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject[] planetprefabs;
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
        SpawnInstantiate(Random.Range(0, planetprefabs.Length));
    }
    public void SpawnInstantiate(int PlanetIndex)
    {
        GameObject planet = (GameObject)Instantiate(planetprefabs[PlanetIndex]);
        NextPlanet();
    }
    void NextPlanet()
    {
        float SpawnInsec;
        if(maxspawnsec > 1f)
        {
            SpawnInsec = Random.Range(1f, maxspawnsec);
        }
        else
            SpawnInsec = 1f;
        Invoke("SpawnPlanet", SpawnInsec);
    }
    void IncreaseDifficulty()
    {
        if(maxspawnsec > 1f)
        {
            maxspawnsec--;
        }
        if(maxspawnsec == 1f)
        {
            CancelInvoke("IncreaseDifficulty");
        }
    }
}
