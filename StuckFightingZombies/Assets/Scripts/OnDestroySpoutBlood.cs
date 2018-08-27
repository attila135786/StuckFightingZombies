using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroySpoutBlood : MonoBehaviour {

    public GameObject[] bloodParticleEffects;

    public void OnDestroy()
    {
        Debug.Log("OnDestroy called");
        Instantiate(bloodParticleEffects[Random.Range(0, bloodParticleEffects.Length)], this.transform.position, Quaternion.identity);
    }
}
