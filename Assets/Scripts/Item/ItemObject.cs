using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteractable
{
    public string GetinteractPrompt();
    public void Oninteract();
}

public class ItemObject : MonoBehaviour , Iinteractable
{
    public ItemData data;

    public string GetinteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void Oninteract()
    {
        CharacterManager.Instance.Player.ItemData = data;
        CharacterManager.Instance.Player.additem?.Invoke();
        Destroy(gameObject);
    }
}
