using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager ins;
    public AudioSource BGM;
    public AudioSource SFX; 
    public AudioSource SFXMechinGun;



    private void Awake()
    {
      if( ins != null)
      {
            Destroy(this.gameObject);
            return;
      }
      else
      {
            ins = this;
      }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        BGM.Play();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        
         SFX.PlayOneShot(sfxClip); 
        
    }

    public void PlayGunSFX(AudioClip gunSFX)
    {
        if (!SFXMechinGun.isPlaying)
        {
            SFXMechinGun.PlayOneShot(gunSFX);
        }
    }
}
