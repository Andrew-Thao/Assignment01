using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public static ReadInput readInput;
    public InputField inputField;
    public Text playerText;
    public static string playerName; 
    public void Start()
    {
        
        if (playerName !=null)
        {
            playerText.text = playerName.ToString ();

        }
    }
    public void ReadStringInput()
    {
        
        playerName = inputField.text;
        playerText.text = playerName;
        Credits.playerName = playerName;

    }
    
}
