using UnityEngine;
using System.Collections;

public class LevelLoadingScript : MonoBehaviour {
	

	
	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}
}
