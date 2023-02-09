using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public void SfxToggle()
    {

        if (SFXManager.sfxInstance.musicToggle == 1)
        {
            SFXManager.sfxInstance.musicToggle = 0;
            //sfxClose.SetActive(true);
            //sfxOpen.SetActive(false);
            PlayerPrefs.SetInt("musictogle", SFXManager.sfxInstance.musicToggle);

        }
        else
        {
            SFXManager.sfxInstance.musicToggle = 1;
            //sfxOpen.SetActive(true);
            //sfxClose.SetActive(false);

            PlayerPrefs.SetInt("musictogle", SFXManager.sfxInstance.musicToggle);
        }
    }
}
