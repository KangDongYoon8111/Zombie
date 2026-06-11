using UnityEngine;

public class VolumeInfo : MonoBehaviour
{
    public float gigaBytes {  get; private set; }
    public float megaBytes
    {
        get { return m_bytes * 0.000001f; } // 1,000,000 * 0.000001 = 1
        
    }

    public float kiloBytes
    {
        get { return m_bytes * 0.001f; } // 1,000,000 * 0.001 = 1000
        set
        {
            if(value <= 0)
            {
                m_bytes = 0;
            }
            else
            {
                m_bytes = value * 1000f;
            }
        }
    }

    public float bytes
    {
        get { return m_bytes; }
        set
        {
            if(value <= 0)
            {
                m_bytes = 0;
            }
            else
            {
                m_bytes = value;
            }
        }
    }

    private float m_bytes = 0f; // 4,000,000
}
