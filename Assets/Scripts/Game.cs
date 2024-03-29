using System.Collections.Generic;
using UnityEngine;

public static class Game
{
    public static GameObject Canvas { get; set; }

    public static Item TakeItem { get; set; }

    public static StatusPlayer StatusPlayer { get; set; } = new StatusPlayer();
}
