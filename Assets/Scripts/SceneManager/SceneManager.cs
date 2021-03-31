using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private void OnEnable()
    {
        DontDestroyOnLoad(this);
    }
}
