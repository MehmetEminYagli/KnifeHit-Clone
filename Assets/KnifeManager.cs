    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> KnifeList = new List<GameObject>();

    [SerializeField] private GameObject KnifePrefab;

    [SerializeField] private int KnifeCount;
    private int knifeIndex;


    //KnifeIcons
    [SerializeField] private List<GameObject> KnifeIconList = new List<GameObject>();
    [SerializeField] private GameObject KnifeIconPrefab;
    [SerializeField] private Vector2 KnifeIconPosition;
    [SerializeField] private Color ActiveIcon;
    [SerializeField] private Color DisableIcon;


    void Start()
    {
        CreateKnife();
        createIcon();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void CreateKnife()
    {
        for (int i = 0; i<KnifeCount; i++)
        {
            GameObject newKnife = Instantiate(KnifePrefab, transform.position, Quaternion.identity);
            newKnife.SetActive(false);
            KnifeList.Add(newKnife);
        }

        KnifeList[0].SetActive(true);
    }


    //býcaklarýaktifetme

    public void SetactiveKnife()
    {
        if (knifeIndex < KnifeList.Count -1)
        {
            knifeIndex++;
            KnifeList[knifeIndex].SetActive(true);
        }
    }

    private void createIcon()
    {
        for(int i = 0; i < KnifeCount; i++)
        {
            GameObject newKnifeIcon = Instantiate(KnifeIconPrefab, KnifeIconPosition, Quaternion.identity);
            //newKnifeIcon.GetComponent<SpriteRenderer>().color = ActiveIcon;
            KnifeIconPosition.y += 0.5f;
            KnifeIconList.Add(newKnifeIcon);
        }
    }

    public void setdisableIcon()
    {
        KnifeIconList[(KnifeIconList.Count - 1) - knifeIndex].gameObject.SetActive(false);
    }

}
