using UnityEngine;

public class DestroyParticleSystem : MonoBehaviour {

    public float defaultIfNoDuration = 5;

    void Start()
    {
        ParticleSystem system = gameObject.GetComponent<ParticleSystem>();

        float duration = system ? system.main.duration: defaultIfNoDuration;
        Destroy(gameObject, duration);
    }
}
