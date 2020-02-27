using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewHeartHealthVisual : MonoBehaviour
{/*
    [SerializeField] private Sprite heart0Sprite;
    [SerializeField] private Sprite heart1Sprite;
    [SerializeField] private Sprite heart2Sprite;
    [SerializeField] private Sprite heart3Sprite;
    [SerializeField] private Sprite heart4Sprite;

    private List<HeartImage> heartImageList;

    private void Awake()
    {
        heartImageList = new List<HeartImage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateHeartImage(new Vector2(0, 0)).SetHeartFrament(4);
        CreateHeartImage(new Vector2(30, 0)).SetHeartFrament(1);
        CreateHeartImage(new Vector2(60, 0)).SetHeartFrament(0);
    }

    private HeartImage CreateHeartImage(Vector2 anchoredPosition)
    {
        GameObject heartGameObject = new GameObject("Heart", typeof(Image));

        heartGameObject.transform.parent = transform;
        heartGameObject.transform.localPosition = Vector3.zero;

        heartGameObject.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
        heartGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(30, 30);

        Image heartImageUI = heartGameObject.GetComponent<Image>();
        heartImageUI.sprite = heart0Sprite;

        HeartImage heartImage = new HeartImage(this,heartImageUI);
        heartImageList.Add(heartImage);

        return heartImage;
    }

    public class HeartImage
    {

        private Image heartImage;
        private NewHeartHealthVisual newHeartHealthVisual;

        public HeartImage(NewHeartHealthVisual newHeartHealthVisual, Image heartImage)
        {
            this.newHeartHealthVisual = newHeartHealthVisual;
            this.heartImage = heartImage;
        }

        public void SetHeartFrament(int fragment)
        {
            switch (fragment)
            {
                case 0: heartImage.sprite = newHeartHealthVisual.heart0Sprite; break;
                case 1: heartImage.sprite = newHeartHealthVisual.heart1Sprite; break;
                case 2: heartImage.sprite = newHeartHealthVisual.heart2Sprite; break;
                case 3: heartImage.sprite = newHeartHealthVisual.heart3Sprite; break;
                case 4: heartImage.sprite = newHeartHealthVisual.heart4Sprite; break;
            }
        }
    }
*/}
