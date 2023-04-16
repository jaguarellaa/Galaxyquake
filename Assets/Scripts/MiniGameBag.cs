using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameBag : MonoBehaviour
{
    public GameObject[] itemBag;
    public GameObject[] itemBox;
    public GameObject bag;

    public bool counter;
    public int count = 0;

    bool[] animBools = new bool[6];

    public GameObject basePanel;
    public GameObject bagPanel;

   


    private void Start()
    {
        counter = true;
    }
    public void DragAnimPiece(int itemIndex)
    {

        itemBag[itemIndex].transform.position = Input.mousePosition;
    }

    public void DropAnimPiece(int animIndex)
    {


        float distance = Vector3.Distance(itemBag[animIndex].gameObject.transform.position, bag.transform.position);

        if (distance < 150)
        {


            itemBag[animIndex].transform.position = itemBox[animIndex].transform.position;

            if (animIndex < 5)
            {
                animBools[animIndex] = true;
                itemBag[animIndex].SetActive(false);
               
            }
            else
            {
                itemBag[animIndex].transform.position = itemBox[animIndex].transform.position;
            }

            count++;

            if (animIndex > 5)
            {
                count--;


            }

        }
        else
        {
            itemBag[animIndex].transform.position =itemBox[animIndex].transform.position;
        }


        if (count == 5)
        {
            WinTime();

        }

    }

    public void WinTime()
    {
        new WaitForSeconds(0.5f);
        bagPanel.SetActive(false);
        basePanel.SetActive(true);
      
    }





}
