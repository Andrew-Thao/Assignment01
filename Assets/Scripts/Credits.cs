using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Credits : MonoBehaviour
{
    public static string playerName;
    public Text playerText;
    public void Quit()
    {

        playerText.text = playerName;
        Debug.Log("QUIT");
        Application.Quit();
    }
   
}
