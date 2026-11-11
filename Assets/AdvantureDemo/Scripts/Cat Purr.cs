using System;
using UnityEngine;

public class CatPurr : MonoBehaviour
{

    [SerializeField] AudioSource purrAudio;
    [SerializeField] float purrCooldown;
    void Start()
    {
        Invoke("PlaySound", purrCooldown);
    }

    void Update()
    {
    }

    private void PlaySound()
    {
        purrAudio.Play();
    }
}
