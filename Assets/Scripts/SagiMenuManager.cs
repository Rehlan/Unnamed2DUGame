using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SagiMenuManager : MonoBehaviour
{
    // Globals
    public const int MAX_NO_PLAYERS = 10;
    public static int num_players = 0;
    public Text num_players_txt;

    public void AddPlayer()
    {
        num_players = ((num_players >= MAX_NO_PLAYERS) ? MAX_NO_PLAYERS : (num_players + 1));
        num_players_txt.text = "Num Players:" + num_players.ToString(); 
    }
    public void SubPlayer()
    {
        num_players = ((num_players <= 0) ? 0 : (num_players - 1));
        num_players_txt.text = "Num Players:" + num_players.ToString(); 
    }
}
