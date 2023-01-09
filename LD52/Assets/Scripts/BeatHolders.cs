using System.Linq;
using UnityEngine;

public class BeatHolders : MonoBehaviour
{
    public GameObject[] childInHolderLeft;
    public bool[] isNotActiveLeft;
    private KeyCode[] _keyToPress = { KeyCode.LeftShift, KeyCode.RightShift };
    
    private CubesController _speed;
    private BeatHolders _holders;

    private void Start()
    {
        _speed = GetComponentInParent<CubesController>();
    }
    
    private void Update()
    {
        for (int i = 0; i < childInHolderLeft.Length; i++)
        {
            
            var minElements = childInHolderLeft.Where
                (x => x != null).Select(x => new
            {
                gameObjectt = x,
                TransformPosition = x.transform.position.y
            }).ToList();

            if (minElements.Count > 0)
            {
                var minY = minElements.Min(x => x.TransformPosition);
                var gameobject = minElements.FirstOrDefault(x =>
                    x.TransformPosition == minY)?.gameObjectt;

                if (!isNotActiveLeft[i] && gameobject != null)
                {
                    if (Input.GetKeyDown(_keyToPress[0]))
                    {
                        if (gameObject.transform.position.x - gameobject.transform.position.x > 0)
                        {
                            isNotActiveLeft[i] = true;
                            Destroy(gameobject);
                            _speed.fallSpeed += 1;
                            break;
                        }
                    }

                    if (Input.GetKeyDown(_keyToPress[1]))
                    {
                        if (gameObject.transform.position.x - gameobject.transform.position.x < 0)
                        {
                            isNotActiveLeft[i] = true;
                            Destroy(gameobject);
                            _speed.fallSpeed += 1;
                            break;
                        }
                    }
                }
            }
        }
    }
}
