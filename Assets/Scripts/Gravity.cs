using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Toon in de Console welk object de bal precies raakt
        Debug.Log("De bal heeft dit object geraakt: " + collision.gameObject.name);
    }
}

public class ChangeColor : MonoBehaviour
{
    // De variabele om de Renderer in te bewaren
    private Renderer mijnRenderer;

    private void Start()
    {
        // Haal de Renderer één keer op bij het starten van de game
        mijnRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Controleer of de Renderer bestaat en of het de bal is die botst
        if (mijnRenderer != null)
        {
            // Genereer een mooie, willekeurige kleur
            Color nieuweKleur = new Color(Random.value, Random.value, Random.value);

            // Verander de kleur van het materiaal direct
            mijnRenderer.material.color = nieuweKleur;
        }
    }
}