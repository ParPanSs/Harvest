using UnityEngine;
using UnityEngine.UIElements;

public class CubesController : MonoBehaviour
{
    public float fallSpeed;
    [SerializeField] private MakeBeesWork script;

    void Start()
    {
        fallSpeed /= 60f;
        script = gameObject.GetComponentInParent<MakeBeesWork>();
    }

    void Update()
    {
        transform.position -= new Vector3(0f, fallSpeed * Time.deltaTime, 0f);
        if (gameObject.transform.childCount == 2)
        {
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                if (gameObject.transform.GetChild(0).childCount + 
                    gameObject.transform.GetChild(1).childCount == 0)
                {
                    script.Success();
                }
            }
        }
    }
}
