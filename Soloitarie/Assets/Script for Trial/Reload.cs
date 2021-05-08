using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    public string scene;
    public void Resets()
    {
        SceneManager.LoadScene(scene);
    }
}
