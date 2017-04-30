using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class ImagesManager : MonoBehaviour
{

    public Sprite TempImage;
    static ImagesManager inistance;

    static Dictionary<string, Sprite> Cache = new Dictionary<string, Sprite>();
    // Use this for initialization
    void Awake()
    {
        if (inistance == null)
        {
            inistance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void LoadImage(string imageUrl, Image Container)
    {
        if (!Cache.ContainsKey(imageUrl))
        {
            inistance.StartCoroutine(LoadImageFromWeb(imageUrl, Container));
        }
        else
        {
            ApplieImage(Cache[imageUrl], Container);
        }
    }

    private static IEnumerator LoadImageFromWeb(string imageUrl, Image container)
    {
        container.sprite = inistance.TempImage;
        WWW www = new WWW(imageUrl);
        yield return www;
        if (www.error == null)
        {
            var sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
            ApplieImage(sprite, container);
            if (!Cache.ContainsKey(imageUrl))
            {
                Cache.Add(imageUrl, sprite);
            }
        }
        else
        {
            Debug.LogError(www.error);
        }
    }

    private static void ApplieImage(Sprite sprite, Image container)
    {
        container.sprite = sprite;
    }
}
