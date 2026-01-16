using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    Material material;
    public float scrollSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // 텍스쳐 초기위치
        Vector2 newOffset = material.mainTextureOffset;
        // 새 위치 지정
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        // 새 위치값 적용
        material.mainTextureOffset = newOffset;
    }
}
