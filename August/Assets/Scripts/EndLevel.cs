using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            GameControl.control.videoPolicy = true;
            GameControl.control.Save();
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
}
