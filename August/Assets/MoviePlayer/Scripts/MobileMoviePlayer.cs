using UnityEngine;
using System.Collections;

public class MobileMoviePlayer : MonoBehaviour
{
		public string movieFileName;
		public Color backgroundColor = Color.black;

		#if UNITY_ANDROID || UNITY_IPHONE
	public FullScreenMovieControlMode controlMod = FullScreenMovieControlMode.Full;
		public FullScreenMovieScalingMode scalingMod = FullScreenMovieScalingMode.Fill;
		#endif

		public bool playOnStart = true;

		IEnumerator Start ()
		{
		Debug.Log (Application.streamingAssetsPath + "/" + movieFileName);
				if (playOnStart) {
						Play ();
				}
				yield return 0;
		}

		/// <summary>
		/// Play the movie
		/// </summary>
		public void Play ()
		{
				if (string.IsNullOrEmpty (movieFileName)) {
						Debug.Log("movieFileName is undefined");
						return;
				}
				#if UNITY_ANDROID || UNITY_IPHONE
					//Play full screen only
					Handheld.PlayFullScreenMovie (movieFileName,  backgroundColor, controlMod,scalingMod);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
				#endif
		}
}