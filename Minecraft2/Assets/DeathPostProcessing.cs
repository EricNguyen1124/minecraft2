using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DeathPostProcessing : MonoBehaviour
{
    PostProcessVolume m_Volume;
    ColorGrading colorGrading;
    Bloom bloom;
    public void DeathColor()
    {
        colorGrading = ScriptableObject.CreateInstance<ColorGrading>();
        bloom = ScriptableObject.CreateInstance<Bloom>();

        bloom.enabled.Override(true);
        bloom.intensity.Override(10f);

        colorGrading.enabled.Override(true);
        colorGrading.saturation.Override(-100f);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, bloom);
        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, colorGrading);
        
    }

}
