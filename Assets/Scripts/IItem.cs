using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public interface IItem
{
    string Name { get; }        //이름

    int ID {  get; }            //ID

    void Use();                 //함수
}

public class weapon : IItem
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int Damage { get; set;}

    public weapon(string name, int id, int damage) 
    { 
        Name = name;
        ID = id;
        Damage = damage;
    }
    public void Use()
    {
        Debug.Log($"Using weapon {Name} with damage{Damage}");
    }
}
public class HealthPotion : IItem
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int HealAmount { get; set; }

    public HealthPotion(string name, int id, int healAmount)
    {
        Name = name;
        ID = id;
        HealAmount = healAmount;
    }
    public void Use()
    {
        Debug.Log($"Using weapon {Name} with damage{HealAmount}");
    }
}

//제네릭 인벤토리 클래스
public class Inventory<T> where T : IItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Debug.Log($"Added {item.Name} to inventory");
    }

    public void UseItem(int index)
    {
        if (index >= 0&& index <items.Count)
        {
            items[index].Use();
        }
        else
        {
            Debug.Log("Invalid item index");
        }
    }
    public void Listitems()
    {
        foreach (var item in items)
        {
            Debug.Log($"value : {item.Name}, Type : {typeof(T)}");
        }
    }
}