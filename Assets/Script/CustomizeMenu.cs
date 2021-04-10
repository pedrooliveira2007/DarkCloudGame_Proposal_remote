using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomizeMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private List<SpriteSelector> spriteSelectors = new List<SpriteSelector>();




    public void SavePrefab()
    {
        PrefabUtility.SaveAsPrefabAsset(player, "Assets/Player.prefab");
    }








}
