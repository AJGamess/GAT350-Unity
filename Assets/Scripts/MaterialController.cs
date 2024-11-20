using UnityEngine;

public class MaterialController : MonoBehaviour
{
    [Range(0.1f, 0.5f)] public float bloat = 0;
    MeshRenderer meshRender;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRender.material.SetFloat("_Bloat", bloat);
    }
}
