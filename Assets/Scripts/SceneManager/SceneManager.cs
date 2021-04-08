using UnityEngine;


[RequireComponent(typeof(GameController))]
public class SceneManager : MonoBehaviour
{
    private void OnEnable()
    {
        DontDestroyOnLoad(this);
    }
}
