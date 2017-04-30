using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour, IItem
{

    public Text title;
    public Image BG;
    public bool isMeal = false;
    public static GameObject description;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init(string mealName)
    {
        if (title != null)
            this.title.text = mealName;

        if (BG != null)
            ImagesManager.LoadImage(DataManager.getMeal(mealName).imgUrl, BG);

        if (isMeal)
        {
            var btn = gameObject.GetComponent<Button>();
            if (btn == null)
            {
                btn= gameObject.AddComponent<Button>();
            }
            btn.onClick.AddListener(() =>
            {
                ShowDescription(mealName);

            });
        }
    }

    private void ShowDescription(string mealName)
    {
        var copy = GameObject.Instantiate(description.gameObject);
        copy.SetActive(true);
        copy.transform.SetParent(description.transform.parent);
        copy.GetComponent<DescriptionScript>().init(mealName);
        copy.transform.localPosition = description.transform.localPosition;
        copy.transform.localScale = description.transform.localScale;
    }
}
