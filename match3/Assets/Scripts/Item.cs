using UnityEngine;

[CreateAssetMenu(menuName = "Match-3/Item")]
public sealed class Item : ScriptableObject
{
    public int value;

    public string nameItem;

    public Sprite sprite; 
}
