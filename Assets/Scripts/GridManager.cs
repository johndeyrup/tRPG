using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {
    public GameObject Hex;
    //How many hexagons we have
    private float gridWidth = 10;
    private float gridHeight = 10;
    private float hexWidth;
    private float hexHeight;

	void Start () {
        //Creates a game object to store the hexes called Hex Grid
        GameObject hexParent = new GameObject("Hex Grid");
        //Create offset for each hex, how much to move the object each x step
        float xoffset = Hex.GetComponent<Renderer>().bounds.size.x;
        //Create offset for each hex, how much to move the object each z step
        float zoffset = Hex.GetComponent<Renderer>().bounds.size.y;
        for (int x = 0; x < gridWidth; x++)
        {
            for (int z = 0; z < gridHeight; z++)
            {
                //Normal x offset is the width of the hexagon but is .5 the width of the hexagon on the second row
                float temp_x_offset = xoffset * x;
                //z offset is always .75 of the height of the hexagon, you want the bottom of the hexagon to be one full length 
                //down minus .25 so the top is in the center of the previous hexagon
                float temp_z_offset = zoffset * z *.75f;
                if (z %2 != 0)
                {
                    temp_x_offset = xoffset *.5f + xoffset * x;
                }

                GameObject hex = (GameObject)Instantiate(Hex);
                hex.name = x.ToString() + ", " + z.ToString();
                Color color = hex.GetComponent<Renderer>().materials[0].color;
                color.a = .2f;
                hex.GetComponent<Renderer>().materials[0].color = color;
                hex.transform.position = new Vector3(temp_x_offset, temp_z_offset, 0);
                hex.transform.parent = hexParent.transform;
            }
            
        }

	}
}
