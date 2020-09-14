using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject Enemybullet;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("fireenemybullet", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void fireenemybullet()
    {
        GameObject playership = GameObject.Find("Player");
        if(playership != null)
        {
            GameObject bullet = (GameObject)Instantiate(Enemybullet);
            bullet.transform.position = transform.position;
            Vector2 direction = playership.transform.position - bullet.transform.position;
            bullet.GetComponent<EnemyBullet>().setdirection(direction);
        }
    }
}
