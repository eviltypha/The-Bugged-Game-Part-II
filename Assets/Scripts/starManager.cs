using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starManager : MonoBehaviour
{
    public GameObject starprefab;
    public int maxstars;
    Color[] starcolors =
    {
        new Color(0.5f, 0.5f, 1f),
        new Color(0f, 1f, 1f),
        new Color(1f, 1f, 0),
        new Color(1f, 0, 0)
    };
    // Start is called before the first frame update
    void Start()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        for(int i = 0; i < maxstars; ++i)
        {
            GameObject stars = (GameObject)Instantiate(starprefab);
            stars.GetComponent<SpriteRenderer>().color = starcolors[i % starcolors.Length];
            starprefab.transform.position = new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
            stars.GetComponent<star>().speed = -(1f * Random.value + 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
