using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public delegate void OnEnd(ItemObject itemObject);
    public event OnEnd? onEnd;

    public ItemObject itemObject;
    public GameObject startCell;
    public GameObject endCell;
    private Image image;

    private void Start()
    {
        this.image = this.GetComponent<Image>();
        onEnd += ParameterPlayer;
        onEnd += EndCell;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        image.raycastTarget = false;
        Game.TakeItem = this;
        this.transform.SetParent(Game.Canvas.transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        onEnd?.Invoke(itemObject);
    }

    public void ParameterPlayer(ItemObject itemObject)
    {
        if (endCell == null)
            return;

        if (startCell.gameObject.tag == "Cell" && endCell.gameObject.tag == "ArmorPlayer")
            StaticScript.AddStat(itemObject);
        else if(startCell.gameObject.tag == "ArmorPlayer" && endCell.gameObject.tag == "Cell")
            StaticScript.RemoveStat(itemObject);

    }

    public void EndCell(ItemObject itemObject)
    {
        Game.TakeItem = null;
        image.raycastTarget = true;
        if (endCell == null)
        {
            this.transform.SetParent(startCell.transform);
            this.transform.localPosition = Vector3.zero;
            return;
        }
        this.transform.SetParent(endCell.transform);
        this.transform.localPosition = Vector3.zero;
        startCell = endCell;
        endCell = null;
    }
}
