using UnityEngine;
using System.Collections;
//using LitJson;
using Sfs2X.Entities.Data;
using System.Collections.Generic;
using System;

enum dataKeys { meals, ingreadiants, categories, Name, Descriptio, How, ParentKey, imgUrl };
public class DataManager : MonoBehaviour
{

    private static ISFSObject DataStorage = new SFSObject();
    private const string DataStoragePrefName = "DS";
    private static DataManager inistance = null;


    public string JSON = "{\"meals\":[{\"Name\":\"Fried Meat\",\"Descriptio\":\"meat but fried\",\"imgUrl\":\"https://dotmsrstaging.s3-eu-west-1.amazonaws.com/uploads/uploads/150208.jpg\",\"How\":\"put meat in hot oil\",\"categories\":[\"Meat\",\"Top Meals\"],\"ingreadiants\":[\"cow meat\",\"salt\",\"Corn oil\"]},{\"Name\":\"Stuffed squash\",\"Descriptio\":\"kosa have rice in it\",\"imgUrl\":\"https://modo3.com/thumbs/fit630x300/38857/1434621906/%D8%B7%D8%B1%D9%8A%D9%82%D8%A9_%D9%85%D8%AD%D8%B4%D9%8A_%D8%A7%D9%84%D9%83%D9%88%D8%B3%D8%A7.jpg\",\"How\":\"put rice in kosa\",\"categories\":[\"Vegetarians\",\"Top Meals\"],\"ingreadiants\":[\"Kosa\",\"salt\",\"Rice\",\"garlic\"]},{\"Name\":\"PopCorn\",\"Descriptio\":\"corn seeds exploded\",\"imgUrl\":\"https://cdn.shutterstock.com/shutterstock/videos/3459194/thumb/1.jpg\",\"How\":\"put corn in hot oil until explode\",\"categories\":[\"Deserts\",\"Top Meals\"],\"ingreadiants\":[\"Corn\",\"salt\",\"Corn oil\"]},{\"Name\":\"Garlic Chicken\",\"Descriptio\":\"\",\"imgUrl\":\"https://cdn.cpnscdn.com/static.coupons.com/ext/kitchme/images/recipes/600x400/a-good-easy-garlic-chicken_5947.jpg\",\"How\":\"Melt butter in a large skillet over medium high heat. Add chicken and sprinkle with garlic powder, seasoning salt and onion powder. Sauté about 10 to 15 minutes on each side, or until chicken is cooked through and juices run clear.\",\"categories\":[\"Meat\"],\"ingreadiants\":[\"butter\",\"salt\",\"onion\",\"garlic \"]}],\"categories\":[\"Top Meals\",\"Meat\",\"Vegetarians\",\"Deserts\"],\"ingreadiants\":[{\"Name\":\"edible\",\"Descriptio\":\"can be eaten\",\"imgUrl\":\"\",\"ParentKey\":\"\"},{\"Name\":\"plants\",\"Descriptio\":\"major\",\"imgUrl\":\"\",\"ParentKey\":\"edible\"},{\"Name\":\"meats\",\"Descriptio\":\"major\",\"imgUrl\":\"\",\"ParentKey\":\"edible\"},{\"Name\":\"spices\",\"Descriptio\":\"major\",\"imgUrl\":\"\",\"ParentKey\":\"edible\"},{\"Name\":\"Rice\",\"Descriptio\":\"common seads\",\"imgUrl\":\"\",\"ParentKey\":\"plants\"},{\"Name\":\"Kosa\",\"Descriptio\":\"major in Egyptian life\",\"imgUrl\":\"\",\"ParentKey\":\"plants\"},{\"Name\":\"Kosa Flower\",\"Descriptio\":\"major in Egyptian life\",\"imgUrl\":\"\",\"ParentKey\":\"Kosa\"},{\"Name\":\"cow\",\"Descriptio\":\"it is well known\",\"imgUrl\":\"\",\"ParentKey\":\"meats\"},{\"Name\":\"cow meat\",\"Descriptio\":\"it is well known also\",\"imgUrl\":\"\",\"ParentKey\":\"cow\"},{\"Name\":\"cow Kaware3\",\"Descriptio\":\"it is well known in egypr\",\"imgUrl\":\"\",\"ParentKey\":\"cow\"},{\"Name\":\"salt\",\"Descriptio\":\"known spice\",\"imgUrl\":\"\",\"ParentKey\":\"spices\"},{\"Name\":\"Corn\",\"Descriptio\":\"known plant\",\"imgUrl\":\"\",\"ParentKey\":\"plants\"},{\"Name\":\"Corn oil\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"Corn\"},{\"Name\":\"garlic\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"plants\"},{\"Name\":\"butter\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"milk\"},{\"Name\":\"chicken breast\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"chicken\"},{\"Name\":\"chicken\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"meats\"},{\"Name\":\"onion\",\"Descriptio\":\"famous oil\",\"imgUrl\":\"\",\"ParentKey\":\"plants\"}]}";


    // Use this for initialization
    void Awake()
    {

        if (inistance == null)
        {
            inistance = this;
        }
        init();

    }



    // Update is called once per frame
    void Update()
    {



    }

    public static void init()
    {
        object x = new object();

        SFSObject data = new SFSObject();
        //data.PutSFSArray(dataKeys.meals.ToString(), new SFSArray());
        //data.PutSFSArray(dataKeys.categories.ToString(), new SFSArray());
        //data.PutSFSArray(dataKeys.ingreadiants.ToString(), new SFSArray());
        ////    data.Add(dataKeys.meals.ToString());
        ////    data.Add(dataKeys.ingreadiants.ToString());
        ////    data.Add(dataKeys.categories.ToString());


        DataStorage = SFSObject.NewFromJsonData(inistance.JSON);

        //AddCategorie("Top Meals");
        //AddCategorie("Meat");
        //AddCategorie("Vegetarians");
        //AddCategorie("Deserts");

        //AddIngreadient(new IngreadientStruct("edible", "can be eaten", ""));

        //AddIngreadient(new IngreadientStruct("plants", "major", "edible"));
        //AddIngreadient(new IngreadientStruct("meats", "major", "edible"));
        //AddIngreadient(new IngreadientStruct("spices", "major", "edible"));

        //AddIngreadient(new IngreadientStruct("Rice", "common seads", "plants"));
        //AddIngreadient(new IngreadientStruct("Kosa", "major in Egyptian life", "plants"));
        //AddIngreadient(new IngreadientStruct("Kosa Flower", "major in Egyptian life", "Kosa"));
        //AddIngreadient(new IngreadientStruct("cow", "it is well known", "meats"));
        //AddIngreadient(new IngreadientStruct("cow meat", "it is well known also", "cow"));
        //AddIngreadient(new IngreadientStruct("cow Kaware3", "it is well known in egypr", "cow"));
        //AddIngreadient(new IngreadientStruct("Sault", "known spice", "spices"));
        //AddIngreadient(new IngreadientStruct("Corn", "known plant", "plants"));
        //AddIngreadient(new IngreadientStruct("Corn oil", "famous oil", "Corn"));



        //AddMeal(new MealStruct("Fried Meat", "meat but fried", new List<string> { "cow meat", "Sault", "Corn oil" }, "put meat in hot oil", new List<string> { "Meat", "Top Meals" }, "https://dotmsrstaging.s3-eu-west-1.amazonaws.com/uploads/uploads/150208.jpg"));
        //AddMeal(new MealStruct("Kosa mahshy", "kosa have rice in it", new List<string> { "Kosa", "Sault", "Rice" }, "put rice in kosa", new List<string> { "Vegetarians", "Top Meals" }, "https://modo3.com/thumbs/fit630x300/38857/1434621906/%D8%B7%D8%B1%D9%8A%D9%82%D8%A9_%D9%85%D8%AD%D8%B4%D9%8A_%D8%A7%D9%84%D9%83%D9%88%D8%B3%D8%A7.jpg"));
        //AddMeal(new MealStruct("PopCorn", "corn seeds exploded", new List<string> { "Corn", "Sault", "Corn oil" }, "put corn in hot oil until explode", new List<string> { "Deserts", "Top Meals" }, "https://cdn.shutterstock.com/shutterstock/videos/3459194/thumb/1.jpg"));

        Debug.Log(data.ToJson());
    }

    public static List<string> getMealsContainKeyWord(string key)
    {

        List<string> mealsList = new List<string>();
        var allMeals = DataStorage.GetSFSArray(dataKeys.meals.ToString());
        for (int i = 0; i < allMeals.Count; i++)
        {
            var meal = new MealStruct((SFSObject)allMeals.GetSFSObject(i));
            if (meal.name.ToLower().Contains(key.ToLower()))
            {
                mealsList.Add(meal.name);
            }
        }

        if (mealsList.Count == 0)
        {
            if (IsDataAvaliable(key, dataKeys.ingreadiants))
            {
                mealsList = getMealsHaveIngreadient(key);
            }
        }

        if (mealsList.Count == 0)
        {
            if (IsDataAvaliable(key, dataKeys.categories))
            {
                mealsList = getMealsInCategorie(key);
            }
        }
        return mealsList;
    }
    internal static List<string> GetFamiltyIngreadients(string IngreadientName)
    {
        var result = new List<string>();
        var allIngreadients = DataStorage.GetSFSArray(dataKeys.ingreadiants.ToString());
        for (int i = 0; i < allIngreadients.Count; i++)
        {
            var ingreadient = new IngreadientStruct((SFSObject)allIngreadients.GetSFSObject(i));
            if (ingreadient.ParentIngreadient == IngreadientName || ingreadient.name == IngreadientName || ingreadient.name ==getIngreadient(IngreadientName).ParentIngreadient)
            {
                result.Add( ingreadient.name);
            }
        }
        return result;
    }
    private static List<string> getMealsHaveIngreadient(string ingreadientName)
    {
        List<string> mealsList = new List<string>();
        var allMeals = DataStorage.GetSFSArray(dataKeys.meals.ToString());
        for (int i = 0; i < allMeals.Count; i++)
        {
            var meal = new MealStruct((SFSObject)allMeals.GetSFSObject(i));
            if (meal.HaveIngreadient(ingreadientName))
            {
                mealsList.Add(meal.name);
            }
        }
        return mealsList;
    }

    internal static List<string> GetExtraMeals(string mealName)
    {
        var mealIngreadients = getMeal(mealName).Ingreadients;

        var spareMealsList = new List<string>();

        var allMeals = DataStorage.GetSFSArray(dataKeys.meals.ToString());

        foreach (var item in mealIngreadients)
        {

            List<string> spareIngradiants = GetChildIngreadients(item) ;

            foreach (var spareIngradiant in spareIngradiants)
            {
                for (int i = 0; i < allMeals.Count; i++)
                {
                    var meal = new MealStruct((SFSObject)allMeals.GetSFSObject(i));
                    if (meal.name != mealName && meal.HaveIngreadient(spareIngradiant))
                    {
                        spareMealsList.Add(meal.name);
                    }
                }
            }
        }
        return (spareMealsList);
    }

    private static List<string> GetChildIngreadients(string IngreadientName)
    {
        var result = new List<string>();
        var allIngreadients = DataStorage.GetSFSArray(dataKeys.ingreadiants.ToString());
        for (int i = 0; i < allIngreadients.Count; i++)
        {
            var ingreadient = new IngreadientStruct((SFSObject)allIngreadients.GetSFSObject(i));
            if (ingreadient.ParentIngreadient == IngreadientName)
            {
                result.Add(ingreadient.name);
            }
        }
        return result;
    }

    internal static IngreadientStruct getIngreadient(string IngreadientName)
    {
        var allIngreadients = DataStorage.GetSFSArray(dataKeys.ingreadiants.ToString());
        for (int i = 0; i < allIngreadients.Count; i++)
        {
            var ingreadient = new IngreadientStruct((SFSObject)allIngreadients.GetSFSObject(i));

            Debug.Log(ingreadient.name + "   " + IngreadientName);
            if (ingreadient.name == IngreadientName)
            {
                return ingreadient;
            }
        }
        return null;
    }
    internal static List<string> getMealsInCategorie(string cat)
    {

        List<string> mealsList = new List<string>();
        var allMeals = DataStorage.GetSFSArray(dataKeys.meals.ToString());
        for (int i = 0; i < allMeals.Count; i++)
        {
            var meal = new MealStruct((SFSObject)allMeals.GetSFSObject(i));
            if (meal.InCategorie(cat))
            {
                mealsList.Add(meal.name);
            }
        }
        return mealsList;
    }
    private static void AddMeal(MealStruct meal)
    {
        var MealsArray = DataStorage.GetSFSArray(dataKeys.meals.ToString());
        if (!IsDataAvaliable(meal.name, dataKeys.meals))
        {
            MealsArray.AddSFSObject(meal.ToSfsObj());
        }
    }

    private static void AddIngreadient(IngreadientStruct ingreadient)
    {
        var ingreadients = DataStorage.GetSFSArray(dataKeys.ingreadiants.ToString());
        if (!IsDataAvaliable(ingreadient.name, dataKeys.ingreadiants))
        {
            ingreadients.AddSFSObject(ingreadient.ToSfsObj());
        }
    }

    private static bool IsDataAvaliable(string Name, dataKeys Categorie)
    {
        var dataArray = DataStorage.GetSFSArray(Categorie.ToString());
        for (int i = 0; i < dataArray.Count; i++)
        {
            if (Categorie == dataKeys.categories)
            {
                if (dataArray.GetUtfString(i) == Name)
                {
                    return true;
                }
            }
            else
            {
                var item = dataArray.GetSFSObject(i);
                if (item.GetUtfString(dataKeys.Name.ToString()) == Name)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private static void AddCategorie(string name)
    {
        var categories = DataStorage.GetSFSArray(dataKeys.categories.ToString());
        if (!IsDataExist(name, categories))
        {
            categories.AddUtfString(name);
        }
    }

    private static bool IsDataExist(string value, ISFSArray categories)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            if (value == categories.GetUtfString(i))
            {
                return true;
            }
        }
        return false;
    }

    internal static List<string> GetCategories()
    {
        var categoriesList = new List<string>();
        var categoriesSfs = DataStorage.GetSFSArray(dataKeys.categories.ToString());
        for (int i = 0; i < categoriesSfs.Count; i++)
        {
            categoriesList.Add(categoriesSfs.GetUtfString(i));
        }

        return categoriesList;
    }

    public static void Save()
    {

        PlayerPrefs.SetString(DataStoragePrefName, DataStorage.ToJson());
    }

    public static void Load()
    {
        if (PlayerPrefs.HasKey(DataStoragePrefName))
        {
            string stringData = PlayerPrefs.GetString(DataStoragePrefName);
            SFSObject x = (SFSObject)SFSObject.NewFromJsonData(stringData);
        }
    }

    public void AddNewCategorie(CategorieStruct categorieData)
    {
        DataStorage.GetSFSObject(dataKeys.categories.ToString());
    }

    private void addToOpject(dataKeys dataKey, string name)
    {
        if (!IsDataAvaliable(name, dataKey))
        {
            var data = DataStorage.GetSFSArray(dataKey.ToString());
            //   data.AddSFSObject(obj);
        }
    }

    internal static MealStruct getMeal(string mealName)
    {
        var allMeals = DataStorage.GetSFSArray(dataKeys.meals.ToString());
        for (int i = 0; i < allMeals.Count; i++)
        {
            var meal = new MealStruct((SFSObject)allMeals.GetSFSObject(i));
            if (meal.name == mealName)
            {
                return meal;
            }
        }
        return null;
    }
}


public abstract class DataStruct
{
    public int index;
    public string name;
    public string Descriptio;
    public string imgUrl;

    public DataStruct(string name, string Descriptio, string imgUrl)
    {
        this.name = name;
        this.Descriptio = Descriptio;
        this.imgUrl = imgUrl;
    }
    public DataStruct(SFSObject obj)
    {
        name = obj.GetUtfString(dataKeys.Name.ToString());
        Descriptio = obj.GetUtfString(dataKeys.Descriptio.ToString());
        imgUrl = obj.GetUtfString(dataKeys.imgUrl.ToString());
    }
    public virtual SFSObject ToSfsObj()
    {
        var data = new SFSObject();
        data.PutUtfString(dataKeys.Name.ToString(), name);
        data.PutUtfString(dataKeys.Descriptio.ToString(), Descriptio);
        data.PutUtfString(dataKeys.imgUrl.ToString(), imgUrl);
        return (data);
    }
}
public class CategorieStruct : DataStruct
{
    public CategorieStruct(SFSObject x) : base(x)
    {

    }
}
public class MealStruct : DataStruct
{

    public List<string> Ingreadients;
    public string How;
    public List<string> Categories;


    public MealStruct(SFSObject obj) : base(obj)
    {
        Categories = new List<string>();
        Ingreadients = new List<string>();

        How = obj.GetUtfString(dataKeys.How.ToString());
        // Categories = obj.GetUtfString(dataKeys.categories.ToString());


        var CategoriesSfsArray = obj.GetSFSArray(dataKeys.categories.ToString());
        for (int i = 0; i < CategoriesSfsArray.Count; i++)
        {
            Categories.Add(CategoriesSfsArray.GetUtfString(i));
        }

        var IngreadientsSfsArray = obj.GetSFSArray(dataKeys.ingreadiants.ToString());
        for (int i = 0; i < IngreadientsSfsArray.Count; i++)
        {
            Ingreadients.Add(IngreadientsSfsArray.GetUtfString(i));
        }
    }

    public MealStruct(string name, string Descriptio, List<string> Ingreadients, string How, List<string> Categories, string imgUrl) : base(name, Descriptio, imgUrl)
    {
        this.Ingreadients = Ingreadients;
        this.How = How;
        this.Categories = Categories;
    }

    override public SFSObject ToSfsObj()
    {
        var data = base.ToSfsObj();
        data.PutUtfString(dataKeys.How.ToString(), How);

        SFSArray CategorieSfsArray = new SFSArray();
        foreach (var item in Categories)
        {
            CategorieSfsArray.AddUtfString(item);
        }
        data.PutSFSArray(dataKeys.categories.ToString(), CategorieSfsArray);

        var ingreadientSfsArray = new SFSArray();
        foreach (var item in Ingreadients)
        {
            ingreadientSfsArray.AddUtfString(item);
        }
        data.PutSFSArray(dataKeys.ingreadiants.ToString(), ingreadientSfsArray);
        return (data);
    }

    internal bool InCategorie(string cat)
    {
        foreach (var item in Categories)
        {
            // Debug.Log("item " + item + " == cat " + cat + ": " + (item == cat));
            if (item == cat)
            {
                return true;
            }
        }
        return false;
    }

    internal bool HaveIngreadient(string ingreadientname)
    {
        foreach (var item in Ingreadients)
        {
            if (item == ingreadientname)
            {
                return true;
            }
        }
        return false;
    }
}
public class IngreadientStruct : DataStruct
{
    public string ParentIngreadient;

    public IngreadientStruct(SFSObject obj) : base(obj)
    {
        ParentIngreadient = obj.GetUtfString(dataKeys.ParentKey.ToString());
        //var ChildKeysSfsArray = obj.GetSFSArray(dataKeys.ChildKeys.ToString());
        //for (int i = 0; i < ChildKeysSfsArray.Count; i++)
        //{
        //    ChildKeys.Add(ChildKeysSfsArray.GetUtfString(i));
        //}
    }

    public IngreadientStruct(string name, string Descriptio, string ParentKey, string imageUrl = "") : base(name, Descriptio, imageUrl)
    {
        this.ParentIngreadient = ParentKey;

    }

    override public SFSObject ToSfsObj()
    {
        var data = base.ToSfsObj();
        data.PutUtfString(dataKeys.ParentKey.ToString(), ParentIngreadient);
        //var ChildKeysSfsArray = new SFSArray();
        //foreach (var item in ChildKeys)
        //{
        //    ChildKeysSfsArray.AddUtfString(item);
        //}
        //data.PutSFSArray(dataKeys.ChildKeys.ToString(), ChildKeysSfsArray);
        return (data);
    }
}