using UnityEngine;

public class Honeycombs : MonoBehaviour
{
    public Animator[] honeycombs;
    public Animator[] bees;
    public AudioSource[] honeyCombsAudio;
    public Animator phone;
    public BoxCollider2D phoneTrigger;
    public AudioSource phoneCall;

    void Update()
    {
        if (bees[1].GetBool("Working") && bees[3].GetBool("Working"))
        {
            honeyCombsAudio[0].Play();
            honeycombs[0].enabled = true;
        }

        if (bees[0].GetBool("Working") && bees[2].GetBool("Working") && bees[4].GetBool("Working"))
        {
            honeyCombsAudio[1].Play();
            honeycombs[1].enabled = true;
        }

        if (bees[1].GetBool("Working") && bees[2].GetBool("Working") &&
            bees[3].GetBool("Working") && bees[5].GetBool("Working"))
        {
            honeyCombsAudio[2].Play();
            honeycombs[2].enabled = true;
        }

        if (honeycombs[0].enabled && honeycombs[1].enabled && honeycombs[2].enabled)
        {
            phone.enabled = true;
            phoneCall.enabled = true;
            phoneTrigger.enabled = true;
        }
    }
}