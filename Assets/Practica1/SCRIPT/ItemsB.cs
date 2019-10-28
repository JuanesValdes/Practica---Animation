using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemsB : MonoBehaviour
{
    public List<Items> item;
    // Start is called before the first frame update
    void Awake()
    {
        item.Add(new Items(20, 40, "mochila"));
        item.Add(new Items(20, 50, "coin"));
        item.Add(new Items(20, 30, "libro"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
