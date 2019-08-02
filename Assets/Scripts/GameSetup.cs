using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public int arrayX = 3;
    public int arrayY = 3;
    public float tileOffset = 0.1f;
    GameObject[,] gameBoard;
    public GameObject tilePrefab;

    // Reset old game
    private void Start()
    {
        CreateGameBoard(arrayX, arrayY);
    }
    // Create array of gameobjects and instantiate prefabs
    void CreateGameBoard(int size_x, int size_y) {
        gameBoard = new GameObject[size_x, size_y];
        for (int i = 0; i < size_x; i++){
            for (int j = 0; j < size_y; j++)
            {
                gameBoard[i, j] = (GameObject)Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }
    // Shuffle gameboard
}
