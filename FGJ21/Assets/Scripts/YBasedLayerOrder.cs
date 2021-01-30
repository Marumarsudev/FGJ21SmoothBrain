using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBasedLayerOrder : MonoBehaviour
{
    private SpriteRenderer sprite;
    [SerializeField] private int offset;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (sprite != null)
        {
            sprite.sortingOrder = (int)(-transform.position.y * 10);
        }
    }
}
