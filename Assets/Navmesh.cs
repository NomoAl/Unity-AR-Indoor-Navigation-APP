using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField] private GameObject navTargetObject;
    [SerializeField] private GameObject start;
    private NavMeshPath path;
    private LineRenderer line;     
    private bool lineToggle = true;

    private void Start()
    {
        path = new NavMeshPath();
        line = GetComponent<LineRenderer>();
        line.enabled = lineToggle; 

    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            lineToggle = !lineToggle;
            line.enabled = lineToggle;
        }

        if (lineToggle)
        {
            NavMesh.CalculatePath(start.transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
        }
    }
}