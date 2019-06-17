using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDefender : MonoBehaviour {

    public  GameObject defenderSelected;
    public CoreGameArea coreGameAreaDefenderToBeSpawned;
    private void OnMouseDown()
    {   
        var selections = FindObjectsOfType<SelectDefender>();//all SelectDefender Objects are held in selections object
        foreach (SelectDefender selection in selections)
        {
            selection.GetComponent<SpriteRenderer>().color = Color.black;
        }

        coreGameAreaDefenderToBeSpawned.selectedDefender(defenderSelected);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    
}
