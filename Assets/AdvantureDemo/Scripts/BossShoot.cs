using UnityEngine;

public class BossShoot : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] AudioSource fireballAudio;
    [SerializeField] AudioClip fireballClip;

    void Start()
    {
        InvokeRepeating("Shoot", 1f, 2f);
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                fireballAudio.PlayOneShot(fireballClip);
    }


}
