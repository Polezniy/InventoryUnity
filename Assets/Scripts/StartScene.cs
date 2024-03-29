using UnityEngine;

public class StartScene : MonoBehaviour
{
    [SerializeField]
    public GameObject canvas;

    [SerializeField]
    public GameObject cells;

    [SerializeField]
    public ItemObject itemObject;

    [SerializeField]
    public bool create;

    private void Start()
    {
        Game.Canvas = canvas;   
    }

    private void OnGUI()
    {
        if (create)
        {
            create = false;
            StaticScript.RenderItemObjToInventory(itemObject , cells);
        }
    }
}
