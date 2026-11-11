using UnityEngine;

public class Platform2 : MonoBehaviour
{

    [SerializeField] float platformSpeed;

    private float _direction = 1f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y += platformSpeed * _direction * Time.fixedDeltaTime;
        pos.y = Mathf.Clamp(pos.y, -1f, 2f);
        transform.position = pos;

        if(pos.y >= 2)
        {
            _direction = -1f;
        }

        else if(pos.y <= -1)
        {
            _direction = 1f;
        }
    }
}
