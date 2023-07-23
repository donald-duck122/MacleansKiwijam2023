using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float spawnInterval = 5f; // Time in seconds before the next laser spawns
    public float despawnDelay = 2f; // Time in seconds before the laser disappears

    public int damageAmount = 1; // The amount of damage the laser does to the player

    public Sprite activatedBase;
    public Sprite deactivatedBase;
    public GameObject laserBase; 
    public GameObject gameManager;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

        InvokeRepeating("SpawnLaser", 0f, spawnInterval);
    }

    private void SpawnLaser()
    {
        spriteRenderer.enabled = true;
        boxCollider.enabled = true;
        laserBase.GetComponent<SpriteRenderer>().sprite = activatedBase;

        Invoke("DespawnLaser", despawnDelay);
    }

    private void DespawnLaser()
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        laserBase.GetComponent<SpriteRenderer>().sprite = deactivatedBase;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("should die");
        if(collision.gameObject.name == ("Player"))
        {
            gameManager.GetComponent<gameManager>().onDeath();
        }
    }
}
