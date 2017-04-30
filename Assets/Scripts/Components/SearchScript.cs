using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SearchScript : MonoBehaviour, IItem
{

    public GameObject tempItem;
    public GameObject Container;
    private SearchScript inistance;
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        tempItem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init(string key)
    {
        var meals = DataManager.getMealsContainKeyWord(key);
        FillContainer(meals, Container, tempItem);
    }

    void clearContainer()
    {
        var count = Container.transform.childCount;
        for (int i = 1; i < count; i++)
        {
            Destroy(Container.transform.GetChild(i).gameObject);
        }
    }
    private void FillContainer(List<string> list, GameObject Container, GameObject TempItem)
    {
        clearContainer();
        foreach (var item in list)
        {
            AddItemToPArent(item, TempItem, Container);
        }
        if (list.Count == 0)
        {
          //  Container.transform.parent.gameObject.SetActive(false);
        }
    }

    private void AddItemToPArent(string item, GameObject TempItem, GameObject Container)
    {
        var temp = GameObject.Instantiate(TempItem);
        temp.name = item;
        temp.gameObject.SetActive(true);
        temp.transform.SetParent(Container.transform);
        temp.GetComponent<IItem>().init(item);
        temp.transform.localScale = Vector3.one;
        temp.GetComponent<Button>().onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
