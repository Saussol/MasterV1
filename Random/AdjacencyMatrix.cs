using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrix : MonoBehaviour
{
    private int[,] adjacencyMatrix;
    public int nodeCount = 5; // Le nombre de n�uds

    void Start()
    {
        adjacencyMatrix = new int[nodeCount, nodeCount];
        GenerateRandomConnections();
        PrintMatrix();
    }

    // G�n�re des connexions al�atoires entre les n�uds
    void GenerateRandomConnections()
    {
        for (int i = 0; i < nodeCount; i++)
        {
            for (int j = i + 1; j < nodeCount; j++)
            {
                // G�n�re al�atoirement une connexion entre les n�uds i et j
                int connection = Random.Range(0, 2); // 0 ou 1
                adjacencyMatrix[i, j] = connection;
                adjacencyMatrix[j, i] = connection; // Sym�trique pour un graphe non orient�
            }
        }
    }

    // Affiche la matrice dans la console
    void PrintMatrix()
    {
        string matrixString = "";
        for (int i = 0; i < nodeCount; i++)
        {
            for (int j = 0; j < nodeCount; j++)
            {
                matrixString += adjacencyMatrix[i, j] + " ";
            }
            matrixString += "\n";
        }
        Debug.Log(matrixString);
    }
}
