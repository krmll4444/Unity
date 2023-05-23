using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public GameObject menuObject;
    private Menu Menu;

    public void Start()
    {
        Menu = menuObject.GetComponent<Menu>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           Menu.AddCheese();

            print("you take 1 cheese");
            this.gameObject.SetActive(false);
        }
    }
}
