using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGenerator : MonoBehaviour {
    public int buildingWidth;
    public int buildingHeight;

    public Sprite[] buildingSpritesWall;
    public Sprite[] buildingSpritesWindow;
    public Sprite[] buildingSpritesTopLeft;
    public Sprite[] buildingSpritesTop;
    public Sprite[] buildingSpritesTopRight;
    public Sprite[] buildingSpritesLeft;
    public Sprite[] buildingSpritesRight;

    public Sprite[] buildingSpritesBandRight;
    public Sprite[] buildingSpritesBandLeft;
    public Sprite[] buildingSpritesBandMiddle;

    public Sprite[] buildingSpritesDecoRight;
    public Sprite[] buildingSpritesDecoLeft;
    public Sprite[] buildingSpritesDecoMiddle;

    public float shadowAmount = 0.01f;

    void Start () {

        int buildingType = Random.Range(0, 2);
        
        buildingWidth = Random.Range(2, 9);
        if (buildingWidth == 5) { buildingWidth = 4; }
        if (buildingWidth == 3) { buildingWidth = 4; }
        if (buildingWidth == 2) { buildingWidth = Random.Range(2, 9);  }
        if (buildingWidth == 5) { buildingWidth = 4; }
        if (buildingWidth == 3) { buildingWidth = 4; }
        buildingHeight = 50;
        
        GameObject go = this.gameObject;
        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y+Random.Range(0,0), go.transform.position.y);

        for (int y = 0; y < buildingHeight; y++)
        {
            if (y == 0)
            {

                for (int x = 0; x <= buildingWidth; x++)
                {
                    if (x == 0)
                    {
                        int endBlock = buildingSpritesTopLeft.Length;
                        GameObject TopLeft = new GameObject();
                        TopLeft.transform.parent = this.gameObject.transform;
                        TopLeft.name = "TopLeft"  + x + y;
                        TopLeft.transform.position = go.transform.position;

                        SpriteRenderer TopLeftSR = TopLeft.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        TopLeftSR.sprite = buildingSpritesTopLeft[random];

                        BoxCollider2D col = TopLeft.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                        Rigidbody2D rb = TopLeft.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

                        rb.isKinematic = true;



                        if (buildingType == 0) {
                            int endBlock2 = buildingSpritesDecoLeft.Length;
                            GameObject TopLeftDeco = new GameObject();
                            TopLeftDeco.transform.parent = this.gameObject.transform;
                            TopLeftDeco.name = "TopLeft Deco" + x + y;
                            TopLeftDeco.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y, go.transform.position.z-0.2f);
                            SpriteRenderer TopLeftDecoSR = TopLeftDeco.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                            int random2 = Random.Range(0, endBlock2);
                            TopLeftDecoSR.sprite = buildingSpritesDecoLeft[random2];
                        }
                    }
                    if (x > 0 && x < buildingWidth)
                    {
                        int endBlock = buildingSpritesTop.Length;
                        GameObject Top = new GameObject();
                        Top.transform.parent = this.gameObject.transform;
                        Top.name = "Top" + x + y;
                        Top.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y, go.transform.position.z);
                        SpriteRenderer TopSR = Top.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        TopSR.sprite = buildingSpritesTop[random];
                        BoxCollider2D col = Top.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                        Rigidbody2D rb = Top.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

                        rb.isKinematic = true;

                        if (buildingType == 0)
                        {
                            int endBlock2 = buildingSpritesDecoMiddle.Length;
                            GameObject TopMiddleDeco = new GameObject();
                            TopMiddleDeco.transform.parent = this.gameObject.transform;
                            TopMiddleDeco.name = "TopMiddle Deco" + x + y;
                            TopMiddleDeco.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y, go.transform.position.z - 0.2f);
                            SpriteRenderer TopMiddleDecoSR = TopMiddleDeco.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                            int random2 = Random.Range(0, endBlock2);
                            TopMiddleDecoSR.sprite = buildingSpritesDecoMiddle[random2];
                        }
                    }
                    if (x == buildingWidth)
                    {
                        int endBlock = buildingSpritesTopRight.Length;
                        GameObject TopRight = new GameObject();
                        TopRight.transform.parent = this.gameObject.transform;
                        TopRight.name = "TopRight" + x + y;
                        TopRight.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y, go.transform.position.z);
                        SpriteRenderer TopRightSR = TopRight.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        TopRightSR.sprite = buildingSpritesTopRight[random];

                        BoxCollider2D col = TopRight.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                        Rigidbody2D rb = TopRight.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

                        rb.isKinematic = true;

                        if (buildingType == 0)
                        {
                            int endBlock2 = buildingSpritesDecoRight.Length;
                            GameObject TopRightDeco = new GameObject();
                            TopRightDeco.transform.parent = this.gameObject.transform;
                            TopRightDeco.name = "Top Right Deco" + x + y;
                            TopRightDeco.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y, go.transform.position.z - 0.2f);
                            SpriteRenderer TopRightDecoSR = TopRightDeco.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                            int random2 = Random.Range(0, endBlock2);
                            TopRightDecoSR.sprite = buildingSpritesDecoRight[random2];
                        }
                    }
                }
            }

            if (y == 1)
            {

                for (int x = 0; x <= buildingWidth; x++)
                {
                    if (x == 0)
                    {
                        int endBlock = buildingSpritesBandLeft.Length;
                        GameObject LeftBand = new GameObject();
                        LeftBand.transform.parent = this.gameObject.transform;
                        LeftBand.name = "LeftBand" + x + y;
                        LeftBand.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - 1, go.transform.position.z);
                        SpriteRenderer LeftSR = LeftBand.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        LeftSR.sprite = buildingSpritesBandLeft[random];
                    }
                    if (x > 0 && x < buildingWidth)
                    {
                        int endBlock = buildingSpritesBandMiddle.Length;
                        GameObject MiddleBand = new GameObject();
                        MiddleBand.transform.parent = this.gameObject.transform;
                        MiddleBand.name = "MiddleBand" + x + y;
                        MiddleBand.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y-1, go.transform.position.z);
                        SpriteRenderer MiddleBandSR = MiddleBand.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        MiddleBandSR.sprite = buildingSpritesBandMiddle[random];
                    }
                    if (x == buildingWidth)
                    {
                        int endBlock = buildingSpritesBandRight.Length;
                        GameObject RightBand = new GameObject();
                        RightBand.transform.parent = this.gameObject.transform;
                        RightBand.name = "RightBand" + x + y;
                        RightBand.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y-1, go.transform.position.z);
                        SpriteRenderer RightBandSR = RightBand.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        int random = Random.Range(0, endBlock);
                        RightBandSR.sprite = buildingSpritesBandRight[random];
                    }
                }
            }

            if (y > 1)
            {
                if(y % 2 == 0) { 
                    for (int x = 0; x <= buildingWidth; x++)
                        {
                            if (x == 0)
                            {
                                int endBlock = buildingSpritesLeft.Length;
                                GameObject Left = new GameObject();
                                Left.transform.parent = this.gameObject.transform;
                                Left.name = "Left" + x + y;
                                Left.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer LeftSR = Left.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                LeftSR.sprite = buildingSpritesLeft[random];
                                LeftSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }
                            if (x > 0 && x < buildingWidth)
                            {
                                
                                    int endBlock = buildingSpritesWall.Length;
                                    GameObject Middle = new GameObject();
                                    Middle.transform.parent = this.gameObject.transform;
                                    Middle.name = "Middle" + x + y;
                                    Middle.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                    SpriteRenderer MiddleSR = Middle.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                    int random = Random.Range(0, endBlock);
                                    MiddleSR.sprite = buildingSpritesWall[random];
                                    MiddleSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));

                        }
                            if (x == buildingWidth)
                            {
                                int endBlock = buildingSpritesRight.Length;
                                GameObject Right = new GameObject();
                                Right.transform.parent = this.gameObject.transform;
                                Right.name = "Right" + x + y;
                                Right.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer RightSR = Right.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                RightSR.sprite = buildingSpritesRight[random];
                                RightSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                        }
                    }
                }

                else
                {
                    int endBlockWindow = buildingSpritesWindow.Length;
                    int randomWindow = Random.Range(0, endBlockWindow);
                    if (Random.Range(0, 5) != 0)
                    {
                        for (int x = 0; x <= buildingWidth; x++)
                        {
                            if (x == 0)
                            {
                                int endBlock = buildingSpritesLeft.Length;
                                GameObject Left = new GameObject();
                                Left.transform.parent = this.gameObject.transform;
                                Left.name = "LeftBand" + x + y;
                                Left.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer LeftSR = Left.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                LeftSR.sprite = buildingSpritesLeft[random];
                                LeftSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }
                            if (x > 0 && x < buildingWidth)
                            {

                                if (x % 2 != 0)
                                {
                                    GameObject Window = new GameObject();
                                    Window.transform.parent = this.gameObject.transform;
                                    Window.name = "Window" + x + y;
                                    Window.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                    SpriteRenderer WindowSR = Window.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                    WindowSR.sprite = buildingSpritesWindow[buildingType];
                                    WindowSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                                }
                                else
                                {
                                    int endBlock = buildingSpritesWall.Length;
                                    GameObject Middle = new GameObject();
                                    Middle.transform.parent = this.gameObject.transform;
                                    Middle.name = "Middle" + x + y;
                                    Middle.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                    SpriteRenderer MiddleSR = Middle.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                    int random = Random.Range(0, endBlock);
                                    MiddleSR.sprite = buildingSpritesWall[random];
                                    MiddleSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                                }




                            }

                            if (x == buildingWidth)
                            {
                                int endBlock = buildingSpritesBandRight.Length;
                                GameObject Right = new GameObject();
                                Right.transform.parent = this.gameObject.transform;
                                Right.name = "RightBand" + x + y;
                                Right.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer RightSR = Right.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                RightSR.sprite = buildingSpritesRight[random];
                                RightSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }
                        }
                    }
                    else {
                        for (int x = 0; x <= buildingWidth; x++)
                        {
                            if (x == 0)
                            {
                                int endBlock = buildingSpritesLeft.Length;
                                GameObject Left = new GameObject();
                                Left.transform.parent = this.gameObject.transform;
                                Left.name = "LeftBand" + x + y;
                                Left.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer LeftSR = Left.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                LeftSR.sprite = buildingSpritesLeft[random];
                                LeftSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }
                            if (x > 0 && x < buildingWidth)
                            {                          
                                 int endBlock = buildingSpritesWall.Length;
                                 GameObject Middle = new GameObject();
                                 Middle.transform.parent = this.gameObject.transform;
                                 Middle.name = "Middle" + x + y;
                                 Middle.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                 SpriteRenderer MiddleSR = Middle.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                 int random = Random.Range(0, endBlock);
                                 MiddleSR.sprite = buildingSpritesWall[random];
                                 MiddleSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }

                            if (x == buildingWidth)
                            {
                                int endBlock = buildingSpritesBandRight.Length;
                                GameObject Right = new GameObject();
                                Right.transform.parent = this.gameObject.transform;
                                Right.name = "RightBand" + x + y;
                                Right.transform.position = new Vector3(go.transform.position.x + x, go.transform.position.y - y, go.transform.position.z);
                                SpriteRenderer RightSR = Right.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                                int random = Random.Range(0, endBlock);
                                RightSR.sprite = buildingSpritesRight[random];
                                RightSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y));
                            }
                        }
                    }

   
                    
                }
            }
        }
    }
	
	
	void Update () {
		
	}

    public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}
