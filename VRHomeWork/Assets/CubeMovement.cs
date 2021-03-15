
using UnityEngine;
using UnityEngine.AI;

public class CubeMovement : MonoBehaviour
{
    NavMeshAgent myAgent;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAgent.speed = speed;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Move();
        }
    }

    void Move()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            myAgent.destination = hit.point;
        }
    }
}
