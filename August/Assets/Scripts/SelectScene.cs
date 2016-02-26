using UnityEngine;
using System.Collections;

public class SelectScene : MonoBehaviour {

	public void selectScene(int scene){
        if (scene == 2)
        {
            if(GameControl.control.videoPolicy == true)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
            }
        }
        else {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
	}
}
