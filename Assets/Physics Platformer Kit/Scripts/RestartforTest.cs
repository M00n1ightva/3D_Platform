using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartforTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Restart!");
        }
    }
}
