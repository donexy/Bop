using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleEnter : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D CastleEnter)
    {
        if (CastleEnter.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

