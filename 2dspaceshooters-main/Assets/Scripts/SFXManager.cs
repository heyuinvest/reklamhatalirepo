using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip PlayerLaser, ExplosionSound;

    public int musicToggle = 1;
    public static SFXManager sfxInstance;


    public GameObject SfxButton;
    // Start is called before the first frame update
    private void Awake()
    {
        if (PlayerPrefs.HasKey("musictogle"))
        {
            musicToggle = PlayerPrefs.GetInt("musictogle");

        }

        else
        {
            musicToggle = 1;
        }


        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }

    void Update()
    {

        if (musicToggle == 1)
        {
            SfxButton.SetActive(true);
        }

        else
        {
            SfxButton.SetActive(false);
        }



    }

}

