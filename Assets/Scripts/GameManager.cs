using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float yBound = 3f;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }
}

