using UnityEngine;
using System.Collections;

public class AppManager : MonoBehaviour {

    public RowScript Row;
    public Transform Container;
    public SearchScript search;

    // Use this for initialization
    void Start () {
        Row.gameObject.SetActive(false);
        var categories = DataManager.GetCategories();
        foreach (var Categorie in categories)
        {
            AddRow(Categorie);
        }
        //AddRow("Top Meals");
        //AddRow("Meat");
        //AddRow("Vegetarian");
        //AddRow("Deserts");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void AddRow(string title)
    {
        Row.gameObject.SetActive(true);
        var temp = GameObject.Instantiate(Row.gameObject);
        var tempScale = temp.transform.localScale;
        temp.GetComponent<RowScript>().init(title);
        temp.transform.SetParent(Container);
        temp.transform.localScale = tempScale;
        Row.gameObject.SetActive(false);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void DoSearch(string Key)
    {
        search.init(Key);


    }
}
