using UnityEngine;

public class Cloude : MonoBehaviour
{
    [SerializeField] float cloudSpeed;

    private float _direction = 1f;
    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.x += cloudSpeed * _direction * Time.fixedDeltaTime;
        pos.x = Mathf.Clamp(pos.x, -10f, 8f);
        transform.position = pos;

        if (pos.x <= -10f)
        {
            _direction = 1f;
        }
        else if (pos.x >= 8f)
        {
            _direction = -1f;
        }
    }
}
