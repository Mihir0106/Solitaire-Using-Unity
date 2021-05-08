using UnityEngine;

// Base class for card piles the player can drag cards onto (discard piles and main piles).
public abstract class InteractableCardPile : CardPile, ICardEndDragTarget
{
    protected BoxCollider2D boxCollider;
    public CardPile CardPile { get { return this; } }

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public abstract bool CardCanBePutOnCard(Card bottomCard, Card topCard); //subclsses must use this 

    // Checks if a card can be put on this card pile when it's dragged directly onto it.
    public abstract bool CardCanBePutOnHere(Card cardToPutOn); //subclsses must use this 

    public override void Remove(Card cardToRemove)  // overridding a card Pile method  Remove() 
    {
        base.Remove(cardToRemove);
        if (Cards.Count == 0)
            boxCollider.enabled = true;
    }
}
