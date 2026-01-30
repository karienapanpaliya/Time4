using UnityEngine;

public class GridSlot : MonoBehaviour
{
    public DialManager dialManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Card card = other.GetComponent<Card>();
        if (card == null) return;

        if (card.cardType == CardType.Increase)
        {
            dialManager.Increase(card.amount);
        }
        else if (card.cardType == CardType.Decrease)
        {
            dialManager.Decrease(card.amount);
        }
    }
}
