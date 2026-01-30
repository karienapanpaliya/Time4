using UnityEngine;

public enum CardType
{
    Increase,
    Decrease
}

public class Card : MonoBehaviour
{
    public CardType cardType;
    public int amount = 1;
}
