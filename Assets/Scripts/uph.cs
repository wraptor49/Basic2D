using UnityEngine;

public class uph : MonoBehaviour
{
    
    public string tagToActivate = "Player";

    public ParticleSystem ps;
    public AudioSource SoundSource;
    public AudioClip PickUpEffekt;

    private void Awake()
    {
        if ((GetComponent<Collider>() == null) && (GetComponent<Collider2D>() == null))
        {
            Debug.Log($"{gameObject} is missing a collider");
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            SoundSource.PlayOneShot(PickUpEffekt);
            ps.Play();
            Destroy(GetComponent<CircleCollider2D>());
            Destroy(GetComponent<SpriteRenderer>());
            Globals.Coins++;
        }
    }

}
