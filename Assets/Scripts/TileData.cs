using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    public int Nummer;

    public void SetNummerText() {
        this.GetComponentInChildren<TextMesh>().text = Nummer.ToString();

    }
}
