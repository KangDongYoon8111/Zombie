using UnityEngine;

public class VolumeInfoTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VolumeInfo info = new VolumeInfo();

        info.bytes = 1000000;
        Debug.Log(info.kiloBytes); // 1000
        Debug.Log(info.megaBytes); // 1

        //info.megaBytes = 4;
        Debug.Log(info.bytes); // 4,000,000
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
