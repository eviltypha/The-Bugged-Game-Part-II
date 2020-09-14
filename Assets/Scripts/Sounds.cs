using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    static AudioSource audiosrc;
    public static AudioClip bullet, timer, gameover, explosion;
    // Start is called before the first frame update
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        bullet = Resources.Load<AudioClip>("smb_fireball");
        timer = Resources.Load<AudioClip>("smb_warning");
        gameover = Resources.Load<AudioClip>("smb_mariodie");
        explosion = Resources.Load<AudioClip>("smb_bowserfire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string Clip)
    {
        switch (Clip)
        {
            case "smb_fireball":
                audiosrc.PlayOneShot(bullet);
                break;
            case "smb_warning":
                audiosrc.PlayOneShot(timer);
                break;
            case "smb_mariodie":
                audiosrc.PlayOneShot(gameover);
                break;
            case "smb_bowserfire":
                audiosrc.PlayOneShot(explosion);
                break;
        }
    }
}
