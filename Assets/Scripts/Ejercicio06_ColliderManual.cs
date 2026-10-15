using UnityEngine;

public class Ejercicio06_ColliderManual : MonoBehaviour
{
    public float speed = 2.0f;
    public Material newMaterial;
    private GameObject target;
    private GameObject obstacle;
    private MeshRenderer obstacleMeshRenderer;
    private bool materialChanged = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindWithTag("Target");
        obstacle = GameObject.FindWithTag("Obstacle");
        obstacleMeshRenderer = obstacle.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!target || !obstacle || !newMaterial) return;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        
        float centerDistance = Vector3.Distance(transform.position, obstacle.transform.position);

        float sphereRadius = transform.localScale.x / 2.0f;
        float cubeRadius = obstacle.transform.localScale.x / 2.0f;

        float collisionMargin = sphereRadius + cubeRadius;

        if (centerDistance <= collisionMargin && !materialChanged)
        {
            obstacleMeshRenderer.material = newMaterial;
            materialChanged = true;
        }
    }
}
