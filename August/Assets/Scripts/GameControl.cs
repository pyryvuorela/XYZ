﻿using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public bool videoPolicy;

	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
            Load();
		} else if (control != this) {
			Destroy (gameObject);
		}
	}
	public void Save(){

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/gameInfo.dat");

		MasterData data = new MasterData ();
		data.videoPolicy = videoPolicy;

		bf.Serialize (file, data);
		file.Close ();

	}
	public void Load(){
        if (File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
            MasterData data = (MasterData)bf.Deserialize(file);
            file.Close();

            videoPolicy = data.videoPolicy;
        }
	}
    public void Reset()
    {
        videoPolicy = false;
        Save();
        Debug.Log(videoPolicy);
    }
}

[Serializable]
class MasterData{
	public bool videoPolicy;
}