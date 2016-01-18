using UnityEngine;
using System.Collections;

public class RestartLevel: MonoBehaviour {
    public void OnMouseDown()
    { Application.LoadLevel(Application.loadedLevel);
        }
}