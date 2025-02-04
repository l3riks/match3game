using UnityEngine;

public sealed class ScrollBoard : MonoBehaviour 
{
    public static ScrollBoard Instance { get; private set; }

    public ScoreContainer[] scoreContainers;

    public int Lenght => scoreContainers.GetLength(0);

    private void Start()
    {
        for (var x = 0; x < Lenght; x++)
        {
            scoreContainers[x].ScoreItem = 0;
        }
    }

    private void Awake() => Instance = this;
}
