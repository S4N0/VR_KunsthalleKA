using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IOpenBookManager : MonoBehaviour
{
    public Image img1, img2;

    public Sprite[] images;

    int currentImageIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (images.Length > 0)
            img1.sprite = images[currentImageIndex];

        if (images.Length > 1)
            img2.sprite = images[currentImageIndex + 1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPage()
    {
        if (images.Length > 2)
        {
            currentImageIndex++;
            currentImageIndex = currentImageIndex > (images.Length - 2) ? images.Length - 2 : currentImageIndex;

            img1.sprite = images[currentImageIndex];
            img2.sprite = images[currentImageIndex + 1];
        }
    }

    public void PreviousPage()
    {
        if (images.Length > 2)
        {
            currentImageIndex--;
            currentImageIndex = currentImageIndex < 0 ? 0 : currentImageIndex;

            img1.sprite = images[currentImageIndex];
            img2.sprite = images[currentImageIndex + 1];
        }
            
    }
}
