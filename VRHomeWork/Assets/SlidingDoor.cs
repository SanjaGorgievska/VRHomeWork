using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public GameObject trigger;
    public GameObject leftDoor;
    public GameObject rightDoor;

    Animator leftAnim;
    Animator rightAnim;

    // Start is called before the first frame update
    void Start()
    {
        leftAnim = leftDoor.GetComponent <Animator >();
        rightAnim = rightDoor.GetComponent <Animator >();
    }

     void OnTriggerEnter(Collider coll)
    {
       if(coll.gameObject.tag == "Player")
        {
            SlideDoors(true);
        }
    }
     void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoors(false);
        }

    }

    void SlideDoors(bool state)
    {
        leftAnim.SetBool("slide", state);
        rightAnim.SetBool("slide", state);
    }
}
