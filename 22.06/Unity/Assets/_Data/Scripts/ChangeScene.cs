using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change(int SceneID)
    {
        SceneManager.LoadSceneAsync(SceneID);
    }
}