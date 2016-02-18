using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void selectScene(int scene){
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
	}
}
