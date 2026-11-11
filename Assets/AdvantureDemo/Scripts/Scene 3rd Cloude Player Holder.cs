using UnityEngine;

public class Cloude2 : MonoBehaviour
{
    [SerializeField] float cloudSpeed;

    private float _direction = 1f;
    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnCollisionStay2D(Collision2D Cloude2)
    {
        if (Cloude2.gameObject.CompareTag("Player"))
        {
            Vector3 pos = transform.position;
            pos.y += cloudSpeed * _direction * Time.fixedDeltaTime;
            pos.y = Mathf.Clamp(pos.y, 0f, 15f);
            transform.position = pos;

            if (pos.y <= 0f)
            {
                _direction = 1f;
            }
            else if (pos.y >= 15f)
            {
                _direction = -1f;
            }
        }
    }
}
