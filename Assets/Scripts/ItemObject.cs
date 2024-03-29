using UnityEngine;

[CreateAssetMenu(menuName = "Item_Object")]
public class ItemObject : ScriptableObject
{
    [SerializeField]
    public string Name;

    [SerializeField]
    public Sprite Sprite;

    [SerializeField]
    public enum ItemRare { Nothing = 0, Head = 1, Boots = 2, Trousers = 3, Bib = 4, Armbands = 5 };
    [SerializeField]
    public ItemRare TypeItem;   

    [SerializeField]
    public float Damage;

    [SerializeField]
    public float HP;
}
