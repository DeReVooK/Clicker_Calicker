using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public int[] Currency;
    public void ModifyCurrency(int currency, int value)
    {
        
        Currency[currency] += value;
    }
}
