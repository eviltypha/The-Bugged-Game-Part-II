using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    public GameObject explosionanimation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);
        transform.position = position;
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemyship" || collision.tag == "planet")
        {
            Sounds.PlaySound("smb_bowserfire");
            Explosion();
            ScoreDisplay.Scorevalue += 100;
            Destroy(gameObject);
        }
    }
    void Explosion()
    {
        GameObject exp = (GameObject)Instantiate(explosionanimation);
        exp.transform.position = transform.position;
    }
}
