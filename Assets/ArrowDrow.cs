using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDrow : MonoBehaviour
{
    //�N���b�N�|�W�V�����o�����
    [SerializeField]

    private Image arrowImage;
    private Vector3 clickPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            
            float size = dist.magnitude;

            float angleRed = Mathf.Atan2(dist.y, dist.x);

            arrowImage.rectTransform.position = clickPosition;

            arrowImage.rectTransform.rotation = Quaternion.Euler(0,0,angleRed * Mathf.Rad2Deg);

            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);
        }
    }
}
