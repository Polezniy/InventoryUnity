using UnityEngine;
using UnityEngine.EventSystems;

public class InventariCell : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    public enum ItemRare { Nothing = 0, Head = 1, Boots = 2, Trousers = 3, Bib = 4, Armbands = 5 };
    [SerializeField]
    public ItemRare TypeItem;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
        if (Game.TakeItem == null)
        {
            return;
        }
        if ((int)TypeItem != 0)
        {
            if ((int)TypeItem != (int)Game.TakeItem.itemObject.TypeItem)
            {
                return;
            }
        }
        Game.TakeItem.endCell = this.gameObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
        if (Game.TakeItem == null)
        {
            return;
        }
        if ((int)TypeItem != 0)
        {
            if ((int)TypeItem != (int)Game.TakeItem.itemObject.TypeItem)
            {
                return;
            }
        }
        Game.TakeItem.endCell = null;
    }
}
