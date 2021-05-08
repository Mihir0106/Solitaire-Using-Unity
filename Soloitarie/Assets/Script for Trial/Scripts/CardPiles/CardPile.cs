using System.Collections.Generic;
using UnityEngine;

public abstract class CardPile : MonoBehaviour
{
    public List<Card> Cards { get; private set; } = new List<Card>();
    protected Card TopCard { get { return Cards.Count > 0 ? Cards[Cards.Count - 1] : null; } }

    public virtual void Clear() // make a reusable method 
    {
        foreach (Card card in Cards)
            Destroy(card.gameObject);
        Cards = new List<Card>();
    }

    public virtual void Add(Card cardToAdd, bool addStepToHistory) // make a reusable method 
    {
        cardToAdd.CardPile = this;
        cardToAdd.SortingOrder = Cards.Count;
        Cards.Add(cardToAdd);        
    }

    public virtual void Remove(Card cardToRemove) // make a reusable method 
    {
        Cards.Remove(cardToRemove);
    }

    public abstract bool CardIsDragable(Card card);   // compulsory for all subclasss to implement it 
}
