using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinObjectManager : MonoBehaviour
{
    public GameObject ship;
    public List<GameObject> skins; 
    private int selectedSkin = 0;
    public GameObject playerskin;

    // Start is called before the first frame update
    void Start()
    {
        skins = new List<GameObject>(Resources.LoadAll<GameObject>("Target"));
        Instantiate(skins[selectedSkin], new Vector2(0, 0), Quaternion.identity);
    }

   

    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        ship = Instantiate(skins[selectedSkin], new Vector2(0,0), Quaternion.identity);
    }

    public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        ship = Instantiate(skins[selectedSkin], new Vector2(0, 0), Quaternion.identity);
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/prefab/selectedskin.prefab");
        SceneManager.LoadScene(7);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
