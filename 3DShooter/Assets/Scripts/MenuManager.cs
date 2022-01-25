using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MenuManager : MonoBehaviour
{

 public static MenuManager instance;

 [SerializeField] 
 private Menu[] menus;
  
 public void OpenMenu(string menuName)
{
    foreach(Menu menu in menus)
    {
        if (menu.menuName == menuName)
        {
            menu.Open();
        }
            else
            { 
                menu.Close();
            }
    }
}
    void Start()
    { 
    instance = this;
    }

    
}
