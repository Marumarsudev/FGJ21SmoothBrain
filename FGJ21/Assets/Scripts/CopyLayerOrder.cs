using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLayerOrder : MonoBehaviour
{
    [SerializeField] private SpriteRenderer copyOrderFrom;
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        sprite.sortingOrder = copyOrderFrom.sortingOrder;
    }
}
