using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScr : MonoBehaviour
{
    public int cellCount;

    private int[] pathID = {6, 7, 8, 9, 10, 11, 12, 13, 14, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 41, 42, 43, 44, 45, 51, 52, 60, 61, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 74, 79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 93, 101, 102, 108, 109, 110, 111, 112, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 139, 140, 141, 142, 143, 144, 145, 146, 147};
    private List<CellScr> AllCells = new List<CellScr>();
    public GameObject cellPref;
    public Transform cellGroup;
    void Start()
    {
        CreateCells();
        CreatePath();
    }

    void CreateCells()
    {
        for (var i = 0; i < cellCount; i++)
        {
            GameObject tmpCell = Instantiate(cellPref);
            tmpCell.transform.SetParent(cellGroup, false);
            tmpCell.GetComponent<CellScr>().id = i + 1;
            tmpCell.GetComponent<CellScr>().SetState(0);
            AllCells.Add(tmpCell.GetComponent<CellScr>());
        }
    }

    void CreatePath()
    {
        for (var i = 0; i < pathID.Length; i++)
            AllCells[pathID[i]-1].SetState(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
