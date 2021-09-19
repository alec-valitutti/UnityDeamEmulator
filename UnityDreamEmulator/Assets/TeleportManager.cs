using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager tm;
    public Action<string> Teleport;
    public void PlayerTeleport(string location)
    {
        Teleport(location);
    }
}
