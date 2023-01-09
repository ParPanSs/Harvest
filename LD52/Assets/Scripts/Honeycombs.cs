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
            honeycombs[0].enabled = true;
            honeyCombsAudio[0].Play();
        }

        if (bees[0].GetBool("Working") && bees[2].GetBool("Working") && bees[4].GetBool("Working"))
        {
            honeycombs[1].enabled = true;
            honeyCombsAudio[1].Play();
        }

        if (bees[1].GetBool("Working") && bees[2].GetBool("Working") &&
            bees[3].GetBool("Working") && bees[5].GetBool("Working"))
        {
            honeycombs[2].enabled = true;
            honeyCombsAudio[2].Play();
        }

        if (honeycombs[0].enabled && honeycombs[1].enabled && honeycombs[2].enabled)
        {
            phone.enabled = true;
            phoneTrigger.enabled = true;
            phoneCall.Play();
        }
    }
}