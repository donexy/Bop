using Unity.VisualScripting;
using UnityEngine;

public class Scene4thCloudePlayerHolder : MonoBehaviour
{
    [SerializeField] float cloudeSpeed;


    private float _direction = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D cloude)
    {
        if (cloude.gameObject.CompareTag("Player"))
        {
            Vector3 pos = transform.position;
            pos.y += cloudeSpeed * _direction * Time.fixedDeltaTime;
            pos.y = Mathf.Clamp(pos.y, -13f, 10f);
            transform.position = pos;
            if (pos.y <= -13f)
            {
                _direction = 1f;
            }
            else if (pos.y >= 10f)
            {
                _direction = -1f;
            }
        }
    }
}
