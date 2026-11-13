using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public Transform shootPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletsAmount;

    public void OnFire(InputValue value)
    {
        if (value.isPressed && bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleEffect.Play();
            shootSound.Play();
        }
    }

}
