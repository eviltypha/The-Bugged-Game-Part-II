using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject bulletplayer;
    public GameObject bulletpos1;
    public GameObject bulletpos2;
    public Text LifeText;
    private int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        LifeText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Sounds.PlaySound("smb_fireball");

            GameObject bullet01 = (GameObject)Instantiate(bulletplayer);
            bullet01.transform.position = bulletpos1.transform.position;

            GameObject bullet02 = (GameObject)Instantiate(bulletplayer);
            bullet02.transform.position = bulletpos2.transform.position;
        }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
        Movement(direction);
    }
    void Movement(Vector2 direction)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        max.x = max.x - 0.225f;
        min.x = min.x + 0.225f;

        max.y = max.y - 0.225f;
        min.y = min.y + 0.225f;

        Vector2 position = transform.position;
        position += direction * speed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, min.x, max.x);
        position.y = Mathf.Clamp(position.y, min.y, max.y);
        transform.position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemyship" || collision.tag == "enemybullet" || collision.tag == "planet")
        {
            lives--;
            LifeText.text = lives.ToString();
            Sounds.PlaySound("smb_bowserfire");
            if(lives == 0)
            {
                Destroy(gameObject);
                //Sounds.PlaySound("smb_mariodie");
                SceneManager.LoadScene("Game Over");
            }
        }
    }
}
