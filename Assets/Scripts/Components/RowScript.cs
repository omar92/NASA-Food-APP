using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class RowScript : MonoBehaviour, IItem
{

    public Text title;
    public ItemScript itemTemp;
    public Transform container;
    public DescriptionScript description;
    // Use this for initialization
    void Start () {
        itemTemp.gameObject.SetActive(false);
        description.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void init(string title)
    {
       this.title.text = title;

     var meals  = DataManager.getMealsInCategorie(title);
        foreach (var MealName in meals)
        {
            AddMeal(MealName);
        }

        if (meals.Count == 0)
        {
            gameObject.SetActive(false);
        }

    }

    void AddMeal(string mealName)
    {
        itemTemp.gameObject.SetActive(true);
        var temp = GameObject.Instantiate(itemTemp.gameObject);
        temp.GetComponent<ItemScript>().init(mealName);
        itemTemp.gameObject.SetActive(false);

        temp.transform.SetParent(container);

    }


}
