using UnityEngine;

public class Honeycombs : MonoBehaviour
{
    public Animator[] honeycombs;
    public Animator[] bees;
    
    void Update()
    {
        if (bees[1].GetBool("Working") && bees[3].GetBool("Working"))
            honeycombs[0].enabled = true;
        if (bees[0].GetBool("Working") && bees[2].GetBool("Working") && bees[4].GetBool("Working"))
            honeycombs[1].enabled = true;
        if (bees[1].GetBool("Working") && bees[2].GetBool("Working") && 
            bees[3].GetBool("Working") && bees[5].GetBool("Working"))
            honeycombs[2].enabled = true;
    }
}