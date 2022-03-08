using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer rnd;

    private void Start()
    {
        rnd = GetComponent<Renderer>();
    }
    private void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        rnd.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

}
