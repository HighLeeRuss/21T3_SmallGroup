using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorldScan : MonoBehaviour
{
    public class Node
    {
        public bool isBlocked;
    }

    private Node[,] gridNodeReference;
    //private Vector2 gridPos;

    public Vector3Int size;
    public Vector3Int gridSize;
    public LayerMask layer;

    private void Start()
    {
        gridNodeReference = new Node[size.x, size.z];
        Pathfind();
    }

    private void Pathfind()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int y = 0; y < size.z; y++)
            {
                gridNodeReference[x, y] = new Node();
                if (Physics.CheckBox(new Vector3(x * gridSize.x, 0, y * gridSize.z),
                    new Vector3(gridSize.x, gridSize.y, gridSize.z), Quaternion.identity, layer))
                {
                    Debug.Log("hit " + layer);
                    gridNodeReference[x, y].isBlocked = true;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (gridNodeReference != null)
        {
            for (int x = 0; x < size.x; x++)
            {
                for (int z = 0; z < size.z; z++)
                {
                    if (gridNodeReference[x, z].isBlocked)
                    {
                        Gizmos.color = Color.red;
                        Gizmos.DrawCube(new Vector3(x, 0, z), Vector3.one);
                    }
                    else
                    {
                        Gizmos.color = Color.green;
                        Gizmos.DrawCube(new Vector3(x, 0, z), Vector3.one);
                    }
                }
            }
        }
    }
}