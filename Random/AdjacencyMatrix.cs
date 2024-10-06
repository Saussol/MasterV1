using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjacencyMatrix : MonoBehaviour
{
    private int[,] adjacencyMatrix;
    public int nodeCount = 5; // Le nombre de nœuds

    void Start()
    {
        adjacencyMatrix = new int[nodeCount, nodeCount];
        GenerateRandomConnections();
        PrintMatrix();
    }

    // Génère des connexions aléatoires entre les nœuds
    void GenerateRandomConnections()
    {
        for (int i = 0; i < nodeCount; i++)
        {
            for (int j = i + 1; j < nodeCount; j++)
            {
                // Génère aléatoirement une connexion entre les nœuds i et j
                int connection = Random.Range(0, 2); // 0 ou 1
                adjacencyMatrix[i, j] = connection;
                adjacencyMatrix[j, i] = connection; // Symétrique pour un graphe non orienté
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
