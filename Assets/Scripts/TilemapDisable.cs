using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapDisable : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }

}
