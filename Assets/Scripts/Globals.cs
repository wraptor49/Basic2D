using UnityEngine;
using UnityEngine.SceneManagement;

public static class Globals
{
    public static int Coins;

    public static void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
