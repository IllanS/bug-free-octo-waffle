using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public static string[] descriptions = {
        "Description of room 1",
        "Description of room 2",
        "Description of room 3",
        "Description of room 4",
        "Description of room 5",
        "Description of room 6",
        "Description of room 7",
        "Description of room 8"
        };

    public static string[,] options =
    {
        {"Gamma", "Epsilon", "Delta", "No Option"},
        {"Espilon", "No Option", "No Option", "No Option"},
        {"Alpha", "Epsilon", "Zeta", "Delta"},
        {"Epsilon", "Zeta", "Gamma", "Eta"},
        {"Alpha", "Delta", "Beta", "Gamma"},
        {"Gamma", "Delta", "No Option", "No Option"},
        {"Theta", "No Option", "No Option", "No Option"},
        {"Eta", "No Option", "No Option", "Collect Treasure"},
    };
}
