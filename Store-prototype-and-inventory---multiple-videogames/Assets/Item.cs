using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Item class of the item object
public class Item : MonoBehaviour
{
    //Item class atributes
    // They can cost one or more Currency(occurrences) (maximum 3 different currency types).
    public int currency;
    //They may contain one or several Product.
    public int Product = 0;
    //can be spent - n stock in the inventory
    public int NStock = 3;
    //cant be spent -  a stock in the inventory
    public int OneStock = 1;

    //Item methods

    //Constructor

    public Item()
    {

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
