using UnityEngine;

public class CatMeow : MonoBehaviour
{
    [SerializeField] AudioSource meowAudio;
    [SerializeField] AudioSource meowAudioSecond;
    [SerializeField] AudioClip meowClipSecond;
    [SerializeField] AudioClip meowClip;
    [SerializeField] float purrCooldown;
    [SerializeField] float purrCooldownSecond;

    void Start()
    {
        Invoke("PlaySound", purrCooldown);
        Invoke("PlaySoundSecond", purrCooldownSecond);

    }
    void PlaySound()
    {
       meowAudio.PlayOneShot(meowClip);
    }
        
    void PlaySoundSecond()
    {
        meowAudioSecond.PlayOneShot(meowClipSecond);
    }

}
