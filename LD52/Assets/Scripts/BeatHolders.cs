using UnityEngine;

public class BeatHolders : MonoBehaviour
{
    public GameObject[] childInHolder;
    public bool[] isNotActive;
    public KeyCode keyToPress;
    private CubesController _speed;
    private BeatHolders _holders;
    private void Start()
    {
        _speed = GameObject.Find("BeatHolder").GetComponent<CubesController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (gameObject.transform.childCount <= 0)
            {
                _speed.fallSpeed = 2;
            }
            for (int i = 0; i < childInHolder.Length; i++)
            {
                if (!isNotActive[i])
                {
                    isNotActive[i] = true;
                    Destroy(childInHolder[i]);               
                    _speed.fallSpeed += 2;
                    break;
                }
            }
        }
    }
}
