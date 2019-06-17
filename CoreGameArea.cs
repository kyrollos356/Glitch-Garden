using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreGameArea : MonoBehaviour {
    GameObject defender ;
    private Vector2 mouseClickPosition;
    float newX, newY;
    private void OnMouseDown()
    {
        mouseClickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y );
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mouseClickPosition);
        newX = Mathf.RoundToInt(worldPos.x);
        newY = Mathf.RoundToInt(worldPos.y);
        Vector2 roundedPos = new Vector2(newX,newY) ;
        istantiateDefender(roundedPos);
    }
    public void selectedDefender(GameObject defenderSelectedFromSelectedDefenderScript)
    {
        defender = defenderSelectedFromSelectedDefenderScript;
    }
    private void istantiateDefender( Vector2 mouseClickPos)
    {
        GameObject newDedender = Instantiate(defender , mouseClickPos,transform.rotation) as GameObject;
    }
}
