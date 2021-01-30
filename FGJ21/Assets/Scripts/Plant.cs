using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Plants
{
    plant1,
    plant2,
    plant3
}

[System.Serializable]
class PlantSprites
{
    public Sprite[] plantSprites;
}

public class Plant : MonoBehaviour
{
    [SerializeField] private float totalGrowthTime;
    [SerializeField] private List<PlantSprites> plantImagesList;
    [SerializeField] private SpriteRenderer progressLight;
    [SerializeField] private Color offColor;
    [SerializeField] private Color growingColor;
    [SerializeField] private Color doneColor;
    [SerializeField] private Plants selectedPlant;

    private float segmentGrowthTime;
    private float timer;
    private int segment;
    private SpriteRenderer sprite;

    void Awake()
    {
        timer = 0f;
        segment = 0;
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = plantImagesList[(int)selectedPlant].plantSprites[segment];
        segmentGrowthTime = totalGrowthTime / plantImagesList[(int)selectedPlant].plantSprites.Length;
    }

    void Update()
    {
        if(segment < plantImagesList[(int)selectedPlant].plantSprites.Length - 1)
        {
            progressLight.color = growingColor;
            timer += Time.deltaTime;

            if(timer >= segmentGrowthTime)
            {
                timer = 0f;
                segment++;
                sprite.sprite = plantImagesList[(int)selectedPlant].plantSprites[segment];
            }
        }
        else
        {
            progressLight.color = doneColor;
        }
    }
}
