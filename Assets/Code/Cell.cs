using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    bool spotIsTaken;

    /// <summary>
    ///  Pointers for all direction on the cell
    /// </summary>

    public GameObject NORTH;
    public GameObject NORTH_WEST;
    public GameObject WEST;
    public GameObject SOUTH_WEST;
    public GameObject SOUTH;
    public GameObject SOUTH_EAST;
    public GameObject EAST;
    public GameObject NORTH_EAST;

    void Start () 
	{
        /// <summary>
        ///  Pointers for all direction on the cell
        /// </summary>

        NORTH = null;
        NORTH_WEST = null;
        WEST = null;
        NORTH_WEST = null;
        SOUTH = null;
        SOUTH_EAST = null;
        EAST = null;
        NORTH_EAST = null;
    }
}
