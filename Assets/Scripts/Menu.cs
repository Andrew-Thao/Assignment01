using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{

    public InputField playerName;
    
 public void StartGame()
    {
        
        Debug.Log("player name is " + playerName.text);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
