using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseButtonCont : MonoBehaviour
{
    public GameObject basePanel;
    public GameObject bagPanel;

   public void Base1()
   {
        bagPanel.SetActive(true);
        basePanel.SetActive(false);
   }
}
