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

    public GameObject emptyGameObject;
    private int buildingType;

    void Start () {

        buildingType = Random.Range(0, 2);
        
        buildingWidth = Random.Range(2, 8);
        if (buildingWidth == 2) { buildingWidth = Random.Range(2, 8); }

        buildingHeight = 79;
        GameObject go = this.gameObject;

        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.y);

        for (int y = 0; y < buildingHeight; y++)
        {
            if (y == 0)
            {

                for (int x = 0; x <= buildingWidth; x++)
                {
                    if (x == 0)
                    {
                        GenerateBuildingTile("TopLeft", x, y, buildingSpritesTopLeft, true, 0);
                        if (buildingType == 1)
                        {
                            GenerateBuildingTile("LeftDeco", x, y, buildingSpritesDecoLeft, false, 0.1f);
                        }

                    }
                    else if (x > 0 && x < buildingWidth)
                    {
                        GenerateBuildingTile("TopMiddle", x, y, buildingSpritesTop, true, 0);
                        if (buildingType == 1)
                        {
                            GenerateBuildingTile("Deco", x, y, buildingSpritesDecoMiddle, false, 0.1f);
                        }
                    }
                    else if (x == buildingWidth)
                    {
                        GenerateBuildingTile("TopRight", x, y, buildingSpritesTopRight, true, 0);

                        if (buildingType == 1)
                        {
                            GenerateBuildingTile("RightDeco", x, y, buildingSpritesDecoRight, false, 0.1f);
                        }
                    }
                    else return;
                }
                
            
            }
            if (y == 1)
            {

                for (int x = 0; x <= buildingWidth; x++)
                {
                    if (x == 0)
                    {
                        GenerateBuildingTile("BandLeft", x, y, buildingSpritesBandLeft, false, 0);

                    }
                    else if (x > 0 && x < buildingWidth)
                    {
                        GenerateBuildingTile("BandMiddle", x, y, buildingSpritesBandMiddle, false, 0);
                    }
                    else if (x == buildingWidth)
                    {
                        GenerateBuildingTile("BandRight", x, y, buildingSpritesBandRight, false, 0);

                    }
                    else return;
                }


            }
            if (y > 1)
            {

                for (int x = 0; x <= buildingWidth; x++)
                {
                    if (x == 0)
                    {
                        GenerateBuildingTile("Left", x, y, buildingSpritesLeft, false, 0);

                    }
                    else if (x > 0 && x < buildingWidth)
                    {
                        GenerateBuildingTile("Middle", x, y, buildingSpritesWall, false, 0);
                        if (x % 2 != 0 && y != 2 && y % 2 != 0)
                        {
                            GenerateWindow("Window", x, y, buildingSpritesWindow, false, 0.01f);
                        }
                        
                    }
                    else if (x == buildingWidth)
                    {
                        GenerateBuildingTile("Right", x, y, buildingSpritesRight, false, 0);

                    }
                    else return;
                }


            }
        }
    }
	
	
	void Update () {
		
	}

    void GenerateBuildingTile(string name,int x, int y, Sprite[] spriteArray, bool collider, float zOffset) {

        int endBlock = spriteArray.Length;
        GameObject clone = new GameObject();
        clone.layer = 8;
        clone.transform.parent = this.transform;
        clone.name = name + x + y;
        clone.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y - y, this.transform.position.z - zOffset);
        SpriteRenderer cloneSR = clone.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        int random = Random.Range(0, endBlock);
        cloneSR.sprite = spriteArray[random];
        cloneSR.color = new Color(1f - (shadowAmount * y), 1f - (shadowAmount * y), 1f - (shadowAmount * y * 0.8f));
        if (collider)
        {
            BoxCollider2D col = clone.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
            Rigidbody2D rb = clone.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

            rb.isKinematic = true;
        }
    }
    void GenerateWindow(string name, int x, int y, Sprite[] spriteArray, bool collider, float zOffset)
    {

        GameObject clone = new GameObject();
        clone.layer = 8;
        clone.transform.parent = this.transform;
        clone.name = name + x + y;
        clone.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y - y, this.transform.position.z - zOffset);
        SpriteRenderer cloneSR = clone.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        cloneSR.sprite = spriteArray[buildingType];
        cloneSR.color = new Color(1f - (shadowAmount * y ), 1f - (shadowAmount * y ), 1f - (shadowAmount * y * 0.8f ));
    }
    
}
