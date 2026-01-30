using UnityEngine;

public class DialManager : MonoBehaviour
{
    public int dialValue = 0;

    public void Increase(int amount)
    {
        dialValue += amount;
        Debug.Log("Dial value: " + dialValue);
    }

    public void Decrease(int amount)
    {
        dialValue -= amount;
        Debug.Log("Dial value: " + dialValue);
    }
}
