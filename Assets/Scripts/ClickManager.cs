using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField] int currency, value;
    GameObject gameManagerObject;
    GameManager gameManager;

    void Start()
    {
        gameManagerObject = GameObject.Find("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    public void Click()
    {
        gameManager.ModifyCurrency(currency, value);
    }
}
