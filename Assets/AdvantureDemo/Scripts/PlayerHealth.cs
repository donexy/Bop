using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}