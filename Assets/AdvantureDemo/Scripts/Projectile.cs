using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] int damage;
    [SerializeField] float speed;
    [SerializeField] string targetTag;


    private Rigidbody2D _rb;

    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
        _rb.linearVelocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {

            if (collision.TryGetComponent(out PlayerHealth playerHealth))
                {
                    playerHealth.TakeDamage(damage);
                }
                else if (collision.TryGetComponent(out BossHealth BossHealth))
                {
                    BossHealth.TakeDamage(damage);

                }

                Destroy(gameObject);
            }
        }
    }


