using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Scene_Manager
{
    // Start is called before the first frame update

    public enum Scene
    {
        Menu,
        First,
        Planet
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
   
}
