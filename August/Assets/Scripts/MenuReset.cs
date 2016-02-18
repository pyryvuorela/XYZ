using UnityEngine;
using System.Collections;

public class MenuReset : MonoBehaviour {

    public void Reset()
    {
        GameControl.control.Reset();
    }
}
