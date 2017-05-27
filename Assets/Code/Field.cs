using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour 
{
    public GameObject cellPrefab;

    private GameObject[,] field;

    private int fieldSize;

    private void CreatePointers()
    {
        for (int i = 0; i < fieldSize; i++)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                if (i == 0)
                {
                    if (j == 0)
                    {
                        field[i, j].GetComponent<Cell>().NORTH = field[i, j + 1];
                        field[i, j].GetComponent<Cell>().NORTH_EAST = field[i + 1, j + 1];
                    }
                    else if (j == fieldSize - 1)
                    {
                        field[i, j].GetComponent<Cell>().SOUTH = field[i, j - 1];
                        field[i, j].GetComponent<Cell>().SOUTH_EAST = field[i + 1, j - 1];
                    }
                    else
                    {
                        field[i, j].GetComponent<Cell>().NORTH = field[i, j + 1];
                        field[i, j].GetComponent<Cell>().SOUTH = field[i, j - 1];
                        field[i, j].GetComponent<Cell>().SOUTH_EAST = field[i + 1, j - 1];
                        field[i, j].GetComponent<Cell>().NORTH_EAST = field[i + 1, j + 1];
                    }

                    field[i, j].GetComponent<Cell>().EAST = field[i + 1, j];
                }
                else if (i == fieldSize - 1)
                {
                    if (j == 0)
                    {
                        field[i, j].GetComponent<Cell>().NORTH = field[i, j + 1];
                        field[i, j].GetComponent<Cell>().NORTH_WEST = field[i - 1, j + 1];

                    }
                    else if (j == fieldSize - 1)
                    {
                        field[i, j].GetComponent<Cell>().SOUTH_WEST = field[i - 1, j - 1];
                        field[i, j].GetComponent<Cell>().SOUTH = field[i, j - 1];
                    }
                    else
                    {
                        field[i, j].GetComponent<Cell>().NORTH = field[i, j + 1];
                        field[i, j].GetComponent<Cell>().NORTH_WEST = field[i - 1, j + 1];
                        field[i, j].GetComponent<Cell>().SOUTH_WEST = field[i - 1, j - 1];
                        field[i, j].GetComponent<Cell>().SOUTH = field[i, j - 1];
                    }

                    field[i, j].GetComponent<Cell>().WEST = field[i - 1, j];
                }
            }
        }
    }

    private void CreateField()
    {
        field = new GameObject[fieldSize, fieldSize];

        for (int i = 0; i < fieldSize; i++)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                GameObject newCell = Instantiate(cellPrefab, Vector2.zero, Quaternion.identity);
                newCell.transform.parent = this.transform;
                field[i, j] = newCell;
                field[i, j].transform.position = new Vector2(i - fieldSize / 2, j - fieldSize / 2);
            }
        }

    }

    void Start () 
	{
        fieldSize = 5;
        CreateField();
        CreatePointers();
	}
}
