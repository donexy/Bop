using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D FallDown)
    {
        if (FallDown.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
