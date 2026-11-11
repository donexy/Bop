using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    private object nextLevel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D NextLevelTriggerEnter)
    {
        if (NextLevelTriggerEnter.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
