using UnityEngine;
using UnityEngine.UI;

public static class StaticScript
{
    public static void RenderItemObjToInventory(ItemObject itemObject , GameObject cells)
    {
        var cell = GetClearCell(cells);  
        if (cell == null) 
        {
            Debug.Log("Свободных мест нет!!!!!!!");
            return;
        }
        //TODO: Возможно стоит добавить шаблон.
        //TODO: Instantiate ???
        var itemGO = new GameObject();
        itemGO.transform.SetParent(cell.transform);
        itemGO.transform.localPosition = Vector3.zero;
        itemGO.transform.localScale = Vector3.one;
        itemGO.AddComponent<Image>().sprite = itemObject.Sprite;
        var item = itemGO.AddComponent<Item>();
        item.itemObject = itemObject;
        item.startCell = cell;
    }

    private static GameObject GetClearCell(GameObject cells)
    {
        for (int i = 0; i < cells.transform.childCount; i++) 
        {
            if (cells.transform.GetChild(i).childCount == 0)
            {
                return cells.transform.GetChild(i).gameObject;
            }
        }
        return null;
    }

    public static void AddStat(ItemObject itemObject)
    {
        Game.StatusPlayer.Damage += itemObject.Damage;
        Game.StatusPlayer.HP += itemObject.HP;
    }
    public static void RemoveStat(ItemObject itemObject)
    {
        Game.StatusPlayer.Damage -= itemObject.Damage;
        Game.StatusPlayer.HP -= itemObject.HP;
    }
}
