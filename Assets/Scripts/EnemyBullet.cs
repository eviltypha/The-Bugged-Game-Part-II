using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float speed;
    Vector2 isdirection;
    bool isready;
    public GameObject explosionanimation;
    // Start is called before the first frame update
    void Awake()
    {
        speed = 3f;
        isready = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isready)
        {
            Vector2 pos = transform.position;
            pos += isdirection * speed * Time.deltaTime;
            transform.position = pos;

            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            if((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
            {
                Destroy(gameObject);
            }
        }
    }
    public void setdirection(Vector2 direction)
    {
        isdirection = direction.normalized;
        isready = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "playership")
        {
            Explosion();
            Destroy(gameObject);
        }
    }
    void Explosion()
    {
        GameObject exp = (GameObject)Instantiate(explosionanimation);
        exp.transform.position = transform.position;
    }
}
