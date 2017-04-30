using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class DescriptionScript : MonoBehaviour, IItem
{


    public Text MealName;
    public Image MealImg;
    public Text MealDescription;
    public Text MealHow;

    public GameObject ingradiantsContainer;
    public GameObject ingradiantTempItem;

    public GameObject CatigoriesContainer;
    public GameObject CatigorieTempItem;

    public GameObject RemainingContainer;
    public GameObject RemainingTempItem;

    public HirarchyScript ingreadientsHirarchy;

    // Use this for initialization
    void Awake()
    {
        ingradiantTempItem.gameObject.SetActive(false);
        CatigorieTempItem.gameObject.SetActive(false);
        RemainingTempItem.gameObject.SetActive(false);

        if (ItemScript.description == null)
        {
            ItemScript.description = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init(string mealName)
    {
        var meal = DataManager.getMeal(mealName);
        MealName.text = meal.name;
        MealDescription.text = meal.Descriptio;
        MealHow.text = meal.How;

        ImagesManager.LoadImage(meal.imgUrl, MealImg);

        FillContainer(meal.Categories, CatigoriesContainer, CatigorieTempItem,(name)=>
        {
            GameObject.Find("InputField").GetComponent<InputField>().text = name;
        });
        FillContainer(meal.Ingreadients, ingradiantsContainer, ingradiantTempItem, (name) =>
        {
            ingreadientsHirarchy.gameObject.SetActive(true);
            ingreadientsHirarchy.init(name);
        });
        FillContainer(DataManager.GetExtraMeals(mealName), RemainingContainer, RemainingTempItem);
    }

    private void FillContainer(List<string> list, GameObject Container, GameObject TempItem, Action<string> callback = null)
    {
        foreach (var item in list)
        {
            AddItemToPArent(item, TempItem, Container, callback);
        }
        if (list.Count == 0)
        {
            Container.transform.parent.gameObject.SetActive(false);
        }
    }

    private void AddItemToPArent(string item, GameObject TempItem, GameObject Container , Action<string> callback )
    {
        var temp = GameObject.Instantiate(TempItem);
        temp.name = item;
        temp.gameObject.SetActive(true);
        temp.transform.SetParent(Container.transform);
        temp.GetComponent<IItem>().init(item);
        temp.transform.localScale = Vector3.one;

        if (temp.GetComponent<Button>() == null)
        {
            temp.AddComponent<Button>();
        }
        temp.GetComponent<Button>().onClick.AddListener(()=>{ if(callback != null) callback(item); });
    }
}
