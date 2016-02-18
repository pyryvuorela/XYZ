using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
            GameControl.control.videoPolicy = true;
            GameControl.control.Save();
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
