using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
   // [SerializeField] private GameObject defender;
    [SerializeField] Defender defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
        Debug.Log("mouse tıklandı");
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        
        return gridPos;
    }
// Cactus snaps to corners too, now we remove decimal points for x and y coordinates
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedWorldPos)
    {
        Defender newDefender = Instantiate(defender, roundedWorldPos, quaternion.identity) as Defender;
    }
}