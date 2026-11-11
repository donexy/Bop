using UnityEngine;

public class DefaultMusic : MonoBehaviour
{
    [SerializeField] AudioSource musicAudio;
    [SerializeField] AudioClip musicClip;
    void Start()
    {
        musicAudio.PlayOneShot(musicClip);
    }

    
        
}
